namespace QLDuAnPhanMemTinHoc.form
{
    partial class NhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpThongTin = new GroupBox();
            txtMatKhau = new TextBox();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            lblTenDangNhap = new Label();
            cboQuyenHan = new ComboBox();
            lblQuyenHan = new Label();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            cboTrangThai = new ComboBox();
            lblTrangThai = new Label();
            cboChucVu = new ComboBox();
            lblChucVu = new Label();
            cboPhongBan = new ComboBox();
            lblPhongBan = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            cboGioiTinh = new ComboBox();
            lblGioiTinh = new Label();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            txtMaNV = new TextBox();
            lblMaNV = new Label();
            btnThemMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            dgvNhanVien = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            lblTimKiem = new Label();
            grpThongTin.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(txtMatKhau);
            grpThongTin.Controls.Add(lblMatKhau);
            grpThongTin.Controls.Add(txtTenDangNhap);
            grpThongTin.Controls.Add(lblTenDangNhap);
            grpThongTin.Controls.Add(cboQuyenHan);
            grpThongTin.Controls.Add(lblQuyenHan);
            grpThongTin.Controls.Add(txtGhiChu);
            grpThongTin.Controls.Add(lblGhiChu);
            grpThongTin.Controls.Add(cboTrangThai);
            grpThongTin.Controls.Add(lblTrangThai);
            grpThongTin.Controls.Add(cboChucVu);
            grpThongTin.Controls.Add(lblChucVu);
            grpThongTin.Controls.Add(cboPhongBan);
            grpThongTin.Controls.Add(lblPhongBan);
            grpThongTin.Controls.Add(dtpNgaySinh);
            grpThongTin.Controls.Add(lblNgaySinh);
            grpThongTin.Controls.Add(cboGioiTinh);
            grpThongTin.Controls.Add(lblGioiTinh);
            grpThongTin.Controls.Add(txtSDT);
            grpThongTin.Controls.Add(lblSDT);
            grpThongTin.Controls.Add(txtEmail);
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(txtHoTen);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Controls.Add(txtMaNV);
            grpThongTin.Controls.Add(lblMaNV);
            grpThongTin.Location = new Point(12, 12);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(976, 260);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin chi tiết nhân viên";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(748, 77);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(207, 27);
            txtMatKhau.TabIndex = 25;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(640, 80);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(73, 20);
            lblMatKhau.TabIndex = 24;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(748, 32);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(207, 27);
            txtTenDangNhap.TabIndex = 23;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(640, 35);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(110, 20);
            lblTenDangNhap.TabIndex = 22;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Nhân viên", "Admin" });
            cboQuyenHan.Location = new Point(420, 167);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(183, 28);
            cboQuyenHan.TabIndex = 21;
            // 
            // lblQuyenHan
            // 
            lblQuyenHan.AutoSize = true;
            lblQuyenHan.Location = new Point(328, 171);
            lblQuyenHan.Name = "lblQuyenHan";
            lblQuyenHan.Size = new Size(82, 20);
            lblQuyenHan.TabIndex = 20;
            lblQuyenHan.Text = "Quyền hạn:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(748, 122);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(207, 115);
            txtGhiChu.TabIndex = 18;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(640, 125);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(61, 20);
            lblGhiChu.TabIndex = 19;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đã nghỉ việc" });
            cboTrangThai.Location = new Point(420, 210);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(183, 28);
            cboTrangThai.TabIndex = 17;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(328, 214);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 16;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Nhân viên", "Trưởng phòng", "Giám đốc" });
            cboChucVu.Location = new Point(420, 122);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(183, 28);
            cboChucVu.TabIndex = 15;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(328, 126);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(64, 20);
            lblChucVu.TabIndex = 14;
            lblChucVu.Text = "Chức vụ:";
            // 
            // cboPhongBan
            // 
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Items.AddRange(new object[] { "Phát triển phần mềm", "Nhân sự", "Kế toán", "Kinh doanh" });
            cboPhongBan.Location = new Point(420, 77);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(183, 28);
            cboPhongBan.TabIndex = 13;
            // 
            // lblPhongBan
            // 
            lblPhongBan.AutoSize = true;
            lblPhongBan.Location = new Point(328, 81);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(83, 20);
            lblPhongBan.TabIndex = 12;
            lblPhongBan.Text = "Phòng ban:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(420, 32);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(183, 27);
            dtpNgaySinh.TabIndex = 11;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(328, 35);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(106, 210);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(183, 28);
            cboGioiTinh.TabIndex = 9;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(14, 214);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 8;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(106, 167);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(183, 27);
            txtSDT.TabIndex = 7;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(14, 171);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(59, 20);
            lblSDT.TabIndex = 6;
            lblSDT.Text = "SĐT (*):";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(106, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 126);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(106, 77);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(183, 27);
            txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(14, 81);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(77, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên (*):";
            // 
            // txtMaNV
            // 
            txtMaNV.Enabled = false;
            txtMaNV.Location = new Point(106, 32);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(183, 27);
            txtMaNV.TabIndex = 1;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(14, 35);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(57, 20);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã NV:";
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(26, 280);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(100, 40);
            btnThemMoi.TabIndex = 1;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.Click += btnThemMoi_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(198, 280);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click_1;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(370, 280);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(542, 280);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 40);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click_1;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(714, 280);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 40);
            btnHuyBo.TabIndex = 5;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.Click += btnHuyBo_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(886, 280);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 40);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvNhanVien);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(lblTimKiem);
            groupBox1.Location = new Point(12, 335);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(976, 320);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(14, 65);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(941, 238);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick_1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(408, 25);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(141, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(250, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(14, 29);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(114, 20);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Nhập tên / SĐT:";
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 667);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThemMoi);
            Controls.Add(grpThongTin);
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblQuyenHan;
        private System.Windows.Forms.ComboBox cboQuyenHan;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
    }
}