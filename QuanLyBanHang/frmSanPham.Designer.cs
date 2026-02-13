namespace QuanLyBanHang
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            txtMoTa = new TextBox();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            cboHangSanXuat = new ComboBox();
            cboLoaiSanPham = new ComboBox();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            label6 = new Label();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            btnTimKiem = new Button();
            btnNhap = new Button();
            btnXuat = new Button();
            btnThem = new Button();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(119, 110);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(412, 23);
            txtMoTa.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(302, 26);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 17;
            label4.Text = "Số lượng (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 55);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 16;
            label5.Text = "Đơn giá (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(txtMoTa);
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
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(856, 181);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(686, 22);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(75, 26);
            btnDoiAnh.TabIndex = 24;
            btnDoiAnh.Text = "Đổi ảnh...";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Image = (Image)resources.GetObject("picHinhAnh.Image");
            picHinhAnh.Location = new Point(552, 23);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(125, 110);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 23;
            picHinhAnh.TabStop = false;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(119, 52);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(166, 23);
            cboHangSanXuat.TabIndex = 22;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(119, 22);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(166, 23);
            cboLoaiSanPham.TabIndex = 21;
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(392, 55);
            numDonGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(139, 23);
            numDonGia.TabIndex = 20;
            numDonGia.ThousandsSeparator = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(392, 23);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(139, 23);
            numSoLuong.TabIndex = 19;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 113);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 15;
            label6.Text = "Mô tả sản phẩm:";
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(362, 149);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(75, 26);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(200, 149);
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
            btnXoa.Location = new Point(281, 149);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 26);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(443, 149);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(75, 26);
            btnHuyBo.TabIndex = 11;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(524, 149);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 26);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(605, 149);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(75, 26);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(686, 149);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(75, 26);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(767, 149);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(75, 26);
            btnXuat.TabIndex = 7;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(119, 149);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 26);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(119, 81);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(412, 23);
            txtTenSanPham.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 55);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 2;
            label3.Text = "Hãng sản xuất (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 84);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên sản phẩm (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Phân loại (*):";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai, TenHangSanXuat, TenSanPham, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 19);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(850, 281);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "HangSanXuat";
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.Name = "TenSanPham";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.Name = "HinhAnh";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Location = new Point(6, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(856, 303);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 494);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SanPham";
            Load += frmSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtMoTa;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnThoat;
        private Button btnTimKiem;
        private Button btnNhap;
        private Button btnXuat;
        private Button btnThem;
        private TextBox txtTenSanPham;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboHangSanXuat;
        private ComboBox cboLoaiSanPham;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}