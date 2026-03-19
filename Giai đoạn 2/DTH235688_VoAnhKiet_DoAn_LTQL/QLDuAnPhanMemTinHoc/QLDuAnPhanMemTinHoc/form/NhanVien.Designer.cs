namespace QLDuAnPhanMemTinHoc.form
{
    partial class NhanVien
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

        #endregion#region Windows Form Designer generated code

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpThongTin = new GroupBox();
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
            lblDanhSach = new Label();
            lblTimKiem = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvNhanVien = new DataGridView();
            grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // grpThongTin
            // 
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
            grpThongTin.Location = new Point(20, 25);
            grpThongTin.Margin = new Padding(3, 4, 3, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(3, 4, 3, 4);
            grpThongTin.Size = new Size(950, 275);
            grpThongTin.TabIndex = 0;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin Nhân viên";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(710, 96);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(210, 129);
            txtGhiChu.TabIndex = 0;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(630, 100);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(61, 20);
            lblGhiChu.TabIndex = 1;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đã nghỉ việc" });
            cboTrangThai.Location = new Point(710, 46);
            cboTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(210, 28);
            cboTrangThai.TabIndex = 2;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(630, 50);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(78, 20);
            lblTrangThai.TabIndex = 3;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Nhân viên", "Trưởng phòng", "Giám đốc" });
            cboChucVu.Location = new Point(430, 196);
            cboChucVu.Margin = new Padding(3, 4, 3, 4);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(160, 28);
            cboChucVu.TabIndex = 4;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Location = new Point(340, 200);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(64, 20);
            lblChucVu.TabIndex = 5;
            lblChucVu.Text = "Chức vụ:";
            // 
            // cboPhongBan
            // 
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Items.AddRange(new object[] { "Phát triển phần mềm", "Nhân sự", "Kế toán", "Kinh doanh" });
            cboPhongBan.Location = new Point(430, 146);
            cboPhongBan.Margin = new Padding(3, 4, 3, 4);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(160, 28);
            cboPhongBan.TabIndex = 6;
            // 
            // lblPhongBan
            // 
            lblPhongBan.AutoSize = true;
            lblPhongBan.Location = new Point(340, 150);
            lblPhongBan.Name = "lblPhongBan";
            lblPhongBan.Size = new Size(83, 20);
            lblPhongBan.TabIndex = 7;
            lblPhongBan.Text = "Phòng ban:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(430, 96);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(160, 27);
            dtpNgaySinh.TabIndex = 8;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(340, 100);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(77, 20);
            lblNgaySinh.TabIndex = 9;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(430, 46);
            cboGioiTinh.Margin = new Padding(3, 4, 3, 4);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(160, 28);
            cboGioiTinh.TabIndex = 10;
            cboGioiTinh.SelectedIndexChanged += cboGioiTinh_SelectedIndexChanged;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(340, 50);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(68, 20);
            lblGioiTinh.TabIndex = 11;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(120, 196);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(180, 27);
            txtSDT.TabIndex = 12;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(30, 200);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(59, 20);
            lblSDT.TabIndex = 13;
            lblSDT.Text = "SĐT (*):";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 146);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(30, 150);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(120, 96);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(180, 27);
            txtHoTen.TabIndex = 16;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(30, 100);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(77, 20);
            lblHoTen.TabIndex = 17;
            lblHoTen.Text = "Họ tên (*):";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(120, 46);
            txtMaNV.Margin = new Padding(3, 4, 3, 4);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(180, 27);
            txtMaNV.TabIndex = 18;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(30, 50);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(57, 20);
            lblMaNV.TabIndex = 19;
            lblMaNV.Text = "Mã NV:";
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(40, 325);
            btnThemMoi.Margin = new Padding(3, 4, 3, 4);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(100, 50);
            btnThemMoi.TabIndex = 10;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(206, 325);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 50);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(372, 325);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 50);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(538, 325);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 50);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(704, 325);
            btnHuyBo.Margin = new Padding(3, 4, 3, 4);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 50);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(870, 325);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 50);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblDanhSach
            // 
            lblDanhSach.AutoSize = true;
            lblDanhSach.Location = new Point(20, 400);
            lblDanhSach.Name = "lblDanhSach";
            lblDanhSach.Size = new Size(147, 20);
            lblDanhSach.TabIndex = 4;
            lblDanhSach.Text = "Danh sách Nhân viên";
            // 
            // lblTimKiem
            // 
            lblTimKiem.AutoSize = true;
            lblTimKiem.Location = new Point(40, 444);
            lblTimKiem.Name = "lblTimKiem";
            lblTimKiem.Size = new Size(114, 20);
            lblTimKiem.TabIndex = 3;
            lblTimKiem.Text = "Nhập tên / SĐT:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(160, 440);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(250, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(430, 438);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(90, 35);
            btnTimKiem.TabIndex = 1;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(20, 481);
            dgvNhanVien.Margin = new Padding(3, 4, 3, 4);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 24;
            dgvNhanVien.Size = new Size(956, 189);
            dgvNhanVien.TabIndex = 0;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellContentClick += dgvNhanVien_CellContentClick;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 709);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(lblTimKiem);
            Controls.Add(lblDanhSach);
            Controls.Add(btnThoat);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThemMoi);
            Controls.Add(grpThongTin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NhanVien";
            Text = "Quản lý Nhân viên";
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();

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

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
    }
}
