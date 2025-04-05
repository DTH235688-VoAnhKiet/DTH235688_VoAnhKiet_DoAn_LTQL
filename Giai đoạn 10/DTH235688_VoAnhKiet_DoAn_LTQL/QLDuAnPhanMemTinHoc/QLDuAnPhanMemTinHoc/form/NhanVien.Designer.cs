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
            tlpThongTin = new TableLayoutPanel();
            lblMaNV = new Label();
            txtMaNV = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblPhongBan = new Label();
            cboPhongBan = new ComboBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblChucVu = new Label();
            cboChucVu = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblQuyenHan = new Label();
            cboQuyenHan = new ComboBox();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            tlpButtons = new TableLayoutPanel();
            btnThemMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            tlpTimKiem = new TableLayoutPanel();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvNhanVien = new DataGridView();
            grpThongTin.SuspendLayout();
            tlpThongTin.SuspendLayout();
            tlpButtons.SuspendLayout();
            groupBox1.SuspendLayout();
            tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
            grpThongTin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpThongTin.Controls.Add(tlpThongTin);
            grpThongTin.Location = new Point(15, 15);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(10);
            grpThongTin.Size = new Size(1014, 260);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin chi tiết nhân viên";
            // 
            // tlpThongTin
            // 
            tlpThongTin.ColumnCount = 6;
            tlpThongTin.ColumnStyles.Add(new ColumnStyle());
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle());
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpThongTin.ColumnStyles.Add(new ColumnStyle());
            tlpThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpThongTin.Controls.Add(lblMaNV, 0, 0);
            tlpThongTin.Controls.Add(txtMaNV, 1, 0);
            tlpThongTin.Controls.Add(lblNgaySinh, 2, 0);
            tlpThongTin.Controls.Add(dtpNgaySinh, 3, 0);
            tlpThongTin.Controls.Add(lblTenDangNhap, 4, 0);
            tlpThongTin.Controls.Add(txtTenDangNhap, 5, 0);
            tlpThongTin.Controls.Add(lblHoTen, 0, 1);
            tlpThongTin.Controls.Add(txtHoTen, 1, 1);
            tlpThongTin.Controls.Add(lblPhongBan, 2, 1);
            tlpThongTin.Controls.Add(cboPhongBan, 3, 1);
            tlpThongTin.Controls.Add(lblMatKhau, 4, 1);
            tlpThongTin.Controls.Add(txtMatKhau, 5, 1);
            tlpThongTin.Controls.Add(lblEmail, 0, 2);
            tlpThongTin.Controls.Add(txtEmail, 1, 2);
            tlpThongTin.Controls.Add(lblChucVu, 2, 2);
            tlpThongTin.Controls.Add(cboChucVu, 3, 2);
            tlpThongTin.Controls.Add(lblGhiChu, 4, 2);
            tlpThongTin.Controls.Add(txtGhiChu, 5, 2);
            tlpThongTin.Controls.Add(lblSDT, 0, 3);
            tlpThongTin.Controls.Add(txtSDT, 1, 3);
            tlpThongTin.Controls.Add(lblQuyenHan, 2, 3);
            tlpThongTin.Controls.Add(cboQuyenHan, 3, 3);
            tlpThongTin.Controls.Add(lblGioiTinh, 0, 4);
            tlpThongTin.Controls.Add(cboGioiTinh, 1, 4);
            tlpThongTin.Controls.Add(lblTrangThai, 2, 4);
            tlpThongTin.Controls.Add(cboTrangThai, 3, 4);
            tlpThongTin.Dock = DockStyle.Fill;
            tlpThongTin.Location = new Point(10, 28);
            tlpThongTin.Name = "tlpThongTin";
            tlpThongTin.RowCount = 5;
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpThongTin.Size = new Size(994, 222);
            tlpThongTin.TabIndex = 0;
            // 
            // lblMaNV
            // 
            lblMaNV.Anchor = AnchorStyles.Left;
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(3, 12);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(55, 19);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            txtMaNV.Dock = DockStyle.Fill;
            txtMaNV.Enabled = false;
            txtMaNV.Location = new Point(81, 8);
            txtMaNV.Margin = new Padding(3, 8, 3, 3);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(217, 25);
            txtMaNV.TabIndex = 1;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Anchor = AnchorStyles.Left;
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(321, 12);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(73, 19);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Dock = DockStyle.Fill;
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(407, 8);
            dtpNgaySinh.Margin = new Padding(3, 8, 3, 3);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(217, 25);
            dtpNgaySinh.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Anchor = AnchorStyles.Left;
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Location = new Point(647, 12);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(103, 19);
            lblTenDangNhap.TabIndex = 4;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Dock = DockStyle.Fill;
            txtTenDangNhap.Location = new Point(756, 8);
            txtTenDangNhap.Margin = new Padding(3, 8, 3, 3);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(235, 25);
            txtTenDangNhap.TabIndex = 5;
            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Left;
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(3, 56);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(72, 19);
            lblHoTen.TabIndex = 6;
            lblHoTen.Text = "Họ tên (*):";
            // 
            // txtHoTen
            // 
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Location = new Point(81, 52);
            txtHoTen.Margin = new Padding(3, 8, 3, 3);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(217, 25);
            txtHoTen.TabIndex = 7;
            // 
            // lblPhongBan
            // 
            lblPhongBan.Anchor = AnchorStyles.Left;
            lblPhongBan.AutoSize = true;
            lblPhongBan.Location = new Point(321, 56);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(79, 19);
            lblPhongBan.TabIndex = 8;
            lblPhongBan.Text = "Phòng ban:";
            // 
            // cboPhongBan
            // 
            cboPhongBan.Dock = DockStyle.Fill;
            cboPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhongBan.Items.AddRange(new object[] { "Phát triển phần mềm", "Nhân sự", "Kế toán", "Kinh doanh" });
            cboPhongBan.Location = new Point(407, 52);
            cboPhongBan.Margin = new Padding(3, 8, 3, 3);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(217, 25);
            cboPhongBan.TabIndex = 9;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Anchor = AnchorStyles.Left;
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(647, 56);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(71, 19);
            lblMatKhau.TabIndex = 10;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Dock = DockStyle.Fill;
            txtMatKhau.Location = new Point(756, 52);
            txtMatKhau.Margin = new Padding(3, 8, 3, 3);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(235, 25);
            txtMatKhau.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(81, 96);
            txtEmail.Margin = new Padding(3, 8, 3, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(217, 25);
            txtEmail.TabIndex = 13;
            // 
            // lblChucVu
            // 
            lblChucVu.Anchor = AnchorStyles.Left;
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(321, 100);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(62, 19);
            lblChucVu.TabIndex = 14;
            lblChucVu.Text = "Chức vụ:";
            // 
            // cboChucVu
            // 
            cboChucVu.Dock = DockStyle.Fill;
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.Items.AddRange(new object[] { "Nhân viên", "Trưởng phòng", "Giám đốc" });
            cboChucVu.Location = new Point(407, 96);
            cboChucVu.Margin = new Padding(3, 8, 3, 3);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(217, 25);
            cboChucVu.TabIndex = 15;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Anchor = AnchorStyles.Left;
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(647, 100);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(59, 19);
            lblGhiChu.TabIndex = 16;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Dock = DockStyle.Fill;
            txtGhiChu.Location = new Point(756, 96);
            txtGhiChu.Margin = new Padding(3, 8, 3, 3);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            tlpThongTin.SetRowSpan(txtGhiChu, 3);
            txtGhiChu.Size = new Size(235, 123);
            txtGhiChu.TabIndex = 17;
            // 
            // lblSDT
            // 
            lblSDT.Anchor = AnchorStyles.Left;
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(3, 144);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(54, 19);
            lblSDT.TabIndex = 18;
            lblSDT.Text = "SĐT (*):";
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Location = new Point(81, 140);
            txtSDT.Margin = new Padding(3, 8, 3, 3);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(217, 25);
            txtSDT.TabIndex = 19;
            // 
            // lblQuyenHan
            // 
            lblQuyenHan.Anchor = AnchorStyles.Left;
            lblQuyenHan.AutoSize = true;
            lblQuyenHan.Location = new Point(321, 144);
            lblQuyenHan.Name = "lblQuyenHan";
            lblQuyenHan.Size = new Size(80, 19);
            lblQuyenHan.TabIndex = 20;
            lblQuyenHan.Text = "Quyền hạn:";
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.Dock = DockStyle.Fill;
            cboQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyenHan.Items.AddRange(new object[] { "Nhân viên", "Admin" });
            cboQuyenHan.Location = new Point(407, 140);
            cboQuyenHan.Margin = new Padding(3, 8, 3, 3);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(217, 25);
            cboQuyenHan.TabIndex = 21;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Anchor = AnchorStyles.Left;
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(3, 189);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(64, 19);
            lblGioiTinh.TabIndex = 22;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.Dock = DockStyle.Fill;
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(81, 184);
            cboGioiTinh.Margin = new Padding(3, 8, 3, 3);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(217, 25);
            cboGioiTinh.TabIndex = 23;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Anchor = AnchorStyles.Left;
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(321, 189);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(73, 19);
            lblTrangThai.TabIndex = 24;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.Dock = DockStyle.Fill;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đã nghỉ việc" });
            cboTrangThai.Location = new Point(407, 184);
            cboTrangThai.Margin = new Padding(3, 8, 3, 3);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(217, 25);
            cboTrangThai.TabIndex = 25;
            // 
            // tlpButtons
            // 
            tlpButtons.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpButtons.ColumnCount = 6;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tlpButtons.Controls.Add(btnThemMoi, 0, 0);
            tlpButtons.Controls.Add(btnSua, 1, 0);
            tlpButtons.Controls.Add(btnXoa, 2, 0);
            tlpButtons.Controls.Add(btnLuu, 3, 0);
            tlpButtons.Controls.Add(btnHuyBo, 4, 0);
            tlpButtons.Controls.Add(btnThoat, 5, 0);
            tlpButtons.Location = new Point(15, 285);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(1014, 50);
            tlpButtons.TabIndex = 8;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Dock = DockStyle.Fill;
            btnThemMoi.Location = new Point(20, 5);
            btnThemMoi.Margin = new Padding(20, 5, 20, 5);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(129, 40);
            btnThemMoi.TabIndex = 0;
            btnThemMoi.Text = "Thêm mới";
            // 
            // btnSua
            // 
            btnSua.Dock = DockStyle.Fill;
            btnSua.Location = new Point(189, 5);
            btnSua.Margin = new Padding(20, 5, 20, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.Location = new Point(358, 5);
            btnXoa.Margin = new Padding(20, 5, 20, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            // 
            // btnLuu
            // 
            btnLuu.Dock = DockStyle.Fill;
            btnLuu.Location = new Point(527, 5);
            btnLuu.Margin = new Padding(20, 5, 20, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 40);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Dock = DockStyle.Fill;
            btnHuyBo.Location = new Point(696, 5);
            btnHuyBo.Margin = new Padding(20, 5, 20, 5);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 40);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            // 
            // btnThoat
            // 
            btnThoat.Dock = DockStyle.Fill;
            btnThoat.Location = new Point(865, 5);
            btnThoat.Margin = new Padding(20, 5, 20, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(tlpTimKiem);
            groupBox1.Controls.Add(dgvNhanVien);
            groupBox1.Location = new Point(15, 345);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(1014, 370);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // tlpTimKiem
            // 
            tlpTimKiem.ColumnCount = 4;
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle());
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tlpTimKiem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTimKiem.Controls.Add(lblTimKiem, 0, 0);
            tlpTimKiem.Controls.Add(txtTimKiem, 1, 0);
            tlpTimKiem.Controls.Add(btnTimKiem, 2, 0);
            tlpTimKiem.Dock = DockStyle.Top;
            tlpTimKiem.Location = new Point(10, 28);
            tlpTimKiem.Name = "tlpTimKiem";
            tlpTimKiem.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTimKiem.Size = new Size(994, 40);
            tlpTimKiem.TabIndex = 0;
            // 
            // lblTimKiem
            // 
            lblTimKiem.Anchor = AnchorStyles.Left;
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(3, 10);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(106, 19);
            lblTimKiem.TabIndex = 0;
            lblTimKiem.Text = "Nhập tên / SĐT:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Dock = DockStyle.Fill;
            txtTimKiem.Location = new Point(117, 5);
            txtTimKiem.Margin = new Padding(5, 5, 20, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(275, 25);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.Location = new Point(412, 3);
            btnTimKiem.Margin = new Padding(0, 3, 0, 3);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(582, 34);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(10, 75);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(994, 285);
            dgvNhanVien.TabIndex = 3;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 730);
            Controls.Add(groupBox1);
            Controls.Add(tlpButtons);
            Controls.Add(grpThongTin);
            Font = new Font("Segoe UI", 10F);
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            grpThongTin.ResumeLayout(false);
            tlpThongTin.ResumeLayout(false);
            tlpThongTin.PerformLayout();
            tlpButtons.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tlpTimKiem.ResumeLayout(false);
            tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
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

        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlpTimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
    }
}