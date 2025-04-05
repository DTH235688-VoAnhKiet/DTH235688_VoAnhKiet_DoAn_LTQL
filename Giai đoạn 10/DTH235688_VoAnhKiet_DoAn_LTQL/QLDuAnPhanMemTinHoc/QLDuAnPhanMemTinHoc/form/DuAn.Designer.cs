namespace QLDuAnPhanMemTinHoc.form
{
    partial class DuAn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlpThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUuTien = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNguoiQuanLy = new System.Windows.Forms.ComboBox();
            this.labelChiPhi = new System.Windows.Forms.Label();
            this.txtChiPhi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
                        this.btnExcel = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDuAn = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tlpTimKiem = new System.Windows.Forms.TableLayoutPanel();
                        this.groupBox1.SuspendLayout();
            this.tlpThongTin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tlpThongTin);

            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
            this.groupBox1.Size = new System.Drawing.Size(1148, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết Dự án";
            // 
            // tlpThongTin
            // 
            this.tlpThongTin.ColumnCount = 6;
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpThongTin.Controls.Add(this.label1, 0, 0);
            this.tlpThongTin.Controls.Add(this.txtMaDA, 1, 0);
            this.tlpThongTin.Controls.Add(this.label5, 2, 0);
            this.tlpThongTin.Controls.Add(this.dtpNgayBatDau, 3, 0);
            this.tlpThongTin.Controls.Add(this.label7, 4, 0);
            this.tlpThongTin.Controls.Add(this.cboUuTien, 5, 0);
            this.tlpThongTin.Controls.Add(this.label2, 0, 1);
            this.tlpThongTin.Controls.Add(this.txtTenDA, 1, 1);
            this.tlpThongTin.Controls.Add(this.label6, 2, 1);
            this.tlpThongTin.Controls.Add(this.dtpNgayKetThuc, 3, 1);
            this.tlpThongTin.Controls.Add(this.label8, 4, 1);
            this.tlpThongTin.Controls.Add(this.cboTrangThai, 5, 1);
            this.tlpThongTin.Controls.Add(this.label3, 0, 2);
            this.tlpThongTin.Controls.Add(this.cboKhachHang, 1, 2);
            this.tlpThongTin.Controls.Add(this.label4, 2, 2);
            this.tlpThongTin.Controls.Add(this.cboNguoiQuanLy, 3, 2);
            this.tlpThongTin.Controls.Add(this.labelChiPhi, 4, 2);
            this.tlpThongTin.Controls.Add(this.txtChiPhi, 5, 2);
            this.tlpThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpThongTin.Location = new System.Drawing.Point(15, 49);
            this.tlpThongTin.Name = "tlpThongTin";
            this.tlpThongTin.RowCount = 3;
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpThongTin.Size = new System.Drawing.Size(1118, 216);
            this.tlpThongTin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã dự án:";
            // 
            // txtMaDA
            // 
            this.txtMaDA.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtMaDA.Location = new System.Drawing.Point(123, 19);
            this.txtMaDA.Margin = new System.Windows.Forms.Padding(3, 19, 20, 3);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(250, 34);
            this.txtMaDA.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày BD:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Dock = System.Windows.Forms.DockStyle.Fill;

            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(513, 19);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(3, 19, 20, 3);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(250, 34);
            this.dtpNgayBatDau.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(786, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Độ ưu tiên:";
            // 
            // cboUuTien
            // 
            this.cboUuTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao", "Khẩn cấp" });
            this.cboUuTien.Location = new System.Drawing.Point(920, 19);
            this.cboUuTien.Margin = new Padding(3, 19, 3, 3);
            this.cboUuTien.Name = "cboUuTien";
            this.cboUuTien.Size = new System.Drawing.Size(195, 36);
            this.cboUuTien.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên DA (*):";
            // 
            // txtTenDA
            // 
            this.txtTenDA.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtTenDA.Location = new System.Drawing.Point(123, 91);
            this.txtTenDA.Margin = new System.Windows.Forms.Padding(3, 19, 20, 3);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(250, 34);
            this.txtTenDA.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày KT:";
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Dock = System.Windows.Forms.DockStyle.Fill;

            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(513, 91);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 19, 20, 3);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(250, 34);
            this.dtpNgayKetThuc.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboTrangThai.Items.AddRange(new object[] { "Mới tạo", "Đang thực hiện", "Hoàn thành", "Tạm dừng" });
            this.cboTrangThai.Location = new System.Drawing.Point(920, 91);
            this.cboTrangThai.Margin = new Padding(3, 19, 3, 3);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(195, 36);
            this.cboTrangThai.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khách hàng:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboKhachHang.Location = new System.Drawing.Point(123, 163);
            this.cboKhachHang.Margin = new Padding(3, 19, 20, 3);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(250, 36);
            this.cboKhachHang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Người QL:";
            // 
            // cboNguoiQuanLy
            // 
            this.cboNguoiQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNguoiQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboNguoiQuanLy.Location = new System.Drawing.Point(513, 163);
            this.cboNguoiQuanLy.Margin = new Padding(3, 19, 20, 3);
            this.cboNguoiQuanLy.Name = "cboNguoiQuanLy";
            this.cboNguoiQuanLy.Size = new System.Drawing.Size(250, 36);
            this.cboNguoiQuanLy.TabIndex = 7;
            // 
            // labelChiPhi
            // 
            this.labelChiPhi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelChiPhi.AutoSize = true;
            this.labelChiPhi.Location = new System.Drawing.Point(786, 165);
            this.labelChiPhi.Name = "labelChiPhi";
            this.labelChiPhi.Size = new System.Drawing.Size(85, 30);
            this.labelChiPhi.TabIndex = 16;
            this.labelChiPhi.Text = "Chi phí:";
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtChiPhi.Location = new System.Drawing.Point(920, 163);
            this.txtChiPhi.Margin = new Padding(3, 19, 3, 3);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(195, 34);
            this.txtChiPhi.TabIndex = 17;
                        // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnThem.Location = new System.Drawing.Point(20, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 45);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
                        // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnSua.Location = new System.Drawing.Point(20, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 45);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
                        // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnXoa.Location = new System.Drawing.Point(20, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 45);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
                        // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnLuu.Location = new System.Drawing.Point(20, 5);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(120, 45);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
                        // 
            // btnHuy
            // 
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnHuy.Location = new System.Drawing.Point(20, 5);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 45);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
                        // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnExcel.Location = new System.Drawing.Point(20, 5);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(120, 45);
            this.btnExcel.TabIndex = 15;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
                        // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnThoat.Location = new System.Drawing.Point(20, 5);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 45);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.ColumnCount = 7;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpButtons.Controls.Add(this.btnThem, 0, 0);
            this.tlpButtons.Controls.Add(this.btnSua, 1, 0);
            this.tlpButtons.Controls.Add(this.btnXoa, 2, 0);
            this.tlpButtons.Controls.Add(this.btnLuu, 3, 0);
            this.tlpButtons.Controls.Add(this.btnHuy, 4, 0);
            this.tlpButtons.Controls.Add(this.btnExcel, 5, 0);
            this.tlpButtons.Controls.Add(this.btnThoat, 6, 0);
            this.tlpButtons.Location = new System.Drawing.Point(16, 310);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(1148, 55);
            this.tlpButtons.TabIndex = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tlpTimKiem);
            this.groupBox2.Controls.Add(this.dgvDuAn);
            this.groupBox2.Location = new System.Drawing.Point(16, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1148, 480);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Dự án";
            // 
            // dgvDuAn
            // 
            this.dgvDuAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDuAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuAn.Location = new System.Drawing.Point(15, 115);
            this.dgvDuAn.Name = "dgvDuAn";
            this.dgvDuAn.RowHeadersWidth = 51;
            this.dgvDuAn.Size = new System.Drawing.Size(1118, 350);
            this.dgvDuAn.TabIndex = 5;
            this.dgvDuAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuAn_CellClick);
            this.dgvDuAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuAn_CellContentClick_1);
            // tlpTimKiem
            // 
            this.tlpTimKiem.ColumnCount = 6;
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTimKiem.Controls.Add(this.label9, 0, 0);
            this.tlpTimKiem.Controls.Add(this.cboLocTrangThai, 1, 0);
            this.tlpTimKiem.Controls.Add(this.label10, 2, 0);
            this.tlpTimKiem.Controls.Add(this.txtTimKiem, 3, 0);
            this.tlpTimKiem.Controls.Add(this.btnTimKiem, 4, 0);
            this.tlpTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTimKiem.Location = new System.Drawing.Point(3, 27);
            this.tlpTimKiem.Name = "tlpTimKiem";
            this.tlpTimKiem.RowCount = 1;
            this.tlpTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTimKiem.Size = new System.Drawing.Size(1142, 40);
            this.tlpTimKiem.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiem.Location = new System.Drawing.Point(747, 5);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 34);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Location = new System.Drawing.Point(427, 5);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 34);
            this.txtTimKiem.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tìm kiếm tên DA:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Mới tạo", "Đang thực hiện", "Hoàn thành", "Tạm dừng" });
            this.cboLocTrangThai.Location = new System.Drawing.Point(98, 5);
            this.cboLocTrangThai.Margin = new System.Windows.Forms.Padding(5);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(195, 38);
            this.cboLocTrangThai.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trạng thái:";
            this.label9.TabIndex = 0;
            this.label9.Text = "Lọc trạng thái:";
            // 
            // DuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 880);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(this.groupBox2);            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimumSize = new System.Drawing.Size(1180, 920);
            this.Name = "DuAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Dự án";
            this.groupBox1.ResumeLayout(false);
            this.tlpThongTin.ResumeLayout(false);
            this.tlpThongTin.PerformLayout();
                        this.tlpButtons.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tlpTimKiem.ResumeLayout(false);
            this.tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNguoiQuanLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUuTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label labelChiPhi;
        private System.Windows.Forms.TextBox txtChiPhi;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tlpTimKiem;
    }
}
