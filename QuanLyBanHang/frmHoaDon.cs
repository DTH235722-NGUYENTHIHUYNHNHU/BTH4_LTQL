using QuanLyBanHang.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();    // Khởi tạo biến ngữ cảnh CSDL 
        int id;                                         // Lấy mã hóa đơn (dùng cho Sửa và Xóa)
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            var hd = context.HoaDon
                .Select(r => new DanhSachHoaDon
                {
                    ID = r.ID,
                    NhanVienID = r.NhanVienID,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    KhachHangID = r.KhachHangID,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    NgayLap = r.NgayLap,
                    GhiChuHoaDon = r.GhiChuHoaDon,
                    TongTienHoaDon = r.HoaDon_ChiTiet
                        .Select(ct => (decimal?)ct.SoLuongBan * ct.DonGiaBan)
                        .Sum() ?? 0,
                    XemChiTiet = "Xem chi tiết"
                })
                .ToList();

            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);

                DialogResult kq = MessageBox.Show(
                    "Bạn có chắc muốn xóa hóa đơn này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (kq == DialogResult.Yes)
                {
                    // Lấy hóa đơn cần xóa
                    HoaDon hd = context.HoaDon.Find(id);

                    if (hd != null)
                    {
                        // Xóa chi tiết hóa đơn
                        var ct = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                        context.HoaDon_ChiTiet.RemoveRange(ct);

                        // Xóa hóa đơn
                        context.HoaDon.Remove(hd);

                        // Lưu thay đổi
                        context.SaveChanges();
                    }

                    // Tải lại form
                    frmHoaDon_Load(sender, e);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (thongbao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
