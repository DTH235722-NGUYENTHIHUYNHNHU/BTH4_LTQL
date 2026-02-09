namespace QuanLyBanHang
{
    partial class frmNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtHoVaTen = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtMatKhau = new TextBox();
            cboQuyenHan = new ComboBox();
            txtTenDangNhap = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDienThoai = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            QuyenHan = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(699, 20);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 26);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(618, 49);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 26);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(618, 78);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 26);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(699, 49);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 26);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(699, 78);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 26);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(796, 20);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 26);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(796, 49);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 26);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(796, 78);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 26);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(1, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(892, 371);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(886, 349);
            dataGridView.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(618, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 26);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(94, 81);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(159, 23);
            txtDiaChi.TabIndex = 4;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(94, 23);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(159, 23);
            txtHoVaTen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 55);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 84);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(cboQuyenHan);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(887, 121);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(419, 52);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(159, 23);
            txtMatKhau.TabIndex = 22;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản Lý", "Nhân Viên" });
            cboQuyenHan.Location = new Point(419, 81);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(159, 23);
            cboQuyenHan.TabIndex = 21;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(419, 23);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(159, 23);
            txtTenDangNhap.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 55);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 17;
            label4.Text = "Mật khẩu (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 84);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 16;
            label5.Text = "Quyền hạn (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 26);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 15;
            label6.Text = "Tên đăng nhập (*):";
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(94, 52);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(159, 23);
            txtDienThoai.TabIndex = 5;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.Name = "HoVaTen";
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.Name = "DienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.Name = "DiaChi";
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.Name = "TenDangNhap";
            // 
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.Name = "QuyenHan";
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 500);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NhanVien";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Button btnThem;
        private TextBox txtDiaChi;
        private TextBox txtHoVaTen;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtDienThoai;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox txtTenDangNhap;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboQuyenHan;
        private TextBox txtMatKhau;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}