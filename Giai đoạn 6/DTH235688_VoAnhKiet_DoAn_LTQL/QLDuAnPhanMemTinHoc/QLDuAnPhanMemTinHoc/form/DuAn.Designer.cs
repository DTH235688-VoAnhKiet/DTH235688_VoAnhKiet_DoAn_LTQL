namespace QLDuAnPhanMemTinHoc.form
{
    partial class DuAn
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

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label8 = new Label();
            cboTrangThai = new ComboBox();
            label7 = new Label();
            cboUuTien = new ComboBox();
            dtpNgayKetThuc = new DateTimePicker();
            label6 = new Label();
            dtpNgayBatDau = new DateTimePicker();
            label5 = new Label();
            cboNguoiQuanLy = new ComboBox();
            label4 = new Label();
            cboKhachHang = new ComboBox();
            label3 = new Label();
            txtTenDA = new TextBox();
            label2 = new Label();
            txtMaDA = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            btnExcel = new Button();
            groupBox2 = new GroupBox();
            dgvDuAn = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label10 = new Label();
            cboLocTrangThai = new ComboBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDuAn).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboUuTien);
            groupBox1.Controls.Add(dtpNgayKetThuc);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpNgayBatDau);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboNguoiQuanLy);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenDA);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaDA);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(16, 18);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1147, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Dự án";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(587, 238);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 14;
            label8.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Mới tạo", "Đang thực hiện", "Hoàn thành", "Tạm dừng" });
            cboTrangThai.Location = new Point(733, 234);
            cboTrangThai.Margin = new Padding(4, 5, 4, 5);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(345, 28);
            cboTrangThai.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 177);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 12;
            label7.Text = "Độ ưu tiên";
            // 
            // cboUuTien
            // 
            cboUuTien.FormattingEnabled = true;
            cboUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao", "Khẩn cấp" });
            cboUuTien.Location = new Point(733, 172);
            cboUuTien.Margin = new Padding(4, 5, 4, 5);
            cboUuTien.Name = "cboUuTien";
            cboUuTien.Size = new Size(345, 28);
            cboUuTien.TabIndex = 13;
            // 
            // dtpNgayKetThuc
            // 
            dtpNgayKetThuc.Format = DateTimePickerFormat.Short;
            dtpNgayKetThuc.Location = new Point(733, 111);
            dtpNgayKetThuc.Margin = new Padding(4, 5, 4, 5);
            dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            dtpNgayKetThuc.Size = new Size(345, 27);
            dtpNgayKetThuc.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(587, 115);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 10;
            label6.Text = "Ngày KT dự kiến";
            // 
            // dtpNgayBatDau
            // 
            dtpNgayBatDau.Format = DateTimePickerFormat.Short;
            dtpNgayBatDau.Location = new Point(733, 49);
            dtpNgayBatDau.Margin = new Padding(4, 5, 4, 5);
            dtpNgayBatDau.Name = "dtpNgayBatDau";
            dtpNgayBatDau.Size = new Size(345, 27);
            dtpNgayBatDau.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 54);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 8;
            label5.Text = "Ngày bắt đầu";
            // 
            // cboNguoiQuanLy
            // 
            cboNguoiQuanLy.FormattingEnabled = true;
            cboNguoiQuanLy.Location = new Point(173, 234);
            cboNguoiQuanLy.Margin = new Padding(4, 5, 4, 5);
            cboNguoiQuanLy.Name = "cboNguoiQuanLy";
            cboNguoiQuanLy.Size = new Size(345, 28);
            cboNguoiQuanLy.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 238);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(138, 20);
            label4.TabIndex = 6;
            label4.Text = "Người quản lý (PM)";
            // 
            // cboKhachHang
            // 
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(173, 172);
            cboKhachHang.Margin = new Padding(4, 5, 4, 5);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(345, 28);
            cboKhachHang.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Khách hàng";
            // 
            // txtTenDA
            // 
            txtTenDA.Location = new Point(173, 111);
            txtTenDA.Margin = new Padding(4, 5, 4, 5);
            txtTenDA.Name = "txtTenDA";
            txtTenDA.Size = new Size(345, 27);
            txtTenDA.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên dự án (*)";
            // 
            // txtMaDA
            // 
            txtMaDA.Location = new Point(173, 49);
            txtMaDA.Margin = new Padding(4, 5, 4, 5);
            txtMaDA.Name = "txtMaDA";
            txtMaDA.Size = new Size(345, 27);
            txtMaDA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã dự án";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(16, 354);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 46);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(189, 354);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 46);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(362, 354);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 46);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(535, 354);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(107, 46);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(708, 354);
            btnHuy.Margin = new Padding(4, 5, 4, 5);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(107, 46);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(881, 354);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 46);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(1054, 354);
            btnExcel.Margin = new Padding(4, 5, 4, 5);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(107, 46);
            btnExcel.TabIndex = 7;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDuAn);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cboLocTrangThai);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(19, 410);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(1147, 333);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Dự án";
            // 
            // dgvDuAn
            // 
            dgvDuAn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDuAn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDuAn.Location = new Point(3, 83);
            dgvDuAn.Margin = new Padding(4, 5, 4, 5);
            dgvDuAn.Name = "dgvDuAn";
            dgvDuAn.RowHeadersWidth = 51;
            dgvDuAn.Size = new Size(1139, 245);
            dgvDuAn.TabIndex = 5;
            dgvDuAn.CellClick += dgvDuAn_CellClick;
            dgvDuAn.CellContentClick += dgvDuAn_CellContentClick_1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1026, 38);
            btnTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(67, 35);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(744, 43);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(265, 27);
            txtTimKiem.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(613, 46);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(123, 20);
            label10.TabIndex = 2;
            label10.Text = "Tìm kiếm tên DA:";
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Mới tạo", "Đang thực hiện", "Hoàn thành", "Tạm dừng" });
            cboLocTrangThai.Location = new Point(133, 42);
            cboLocTrangThai.Margin = new Padding(4, 5, 4, 5);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(199, 28);
            cboLocTrangThai.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 46);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 0;
            label9.Text = "Lọc trạng thái:";
            // 
            // DuAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 784);
            Controls.Add(groupBox2);
            Controls.Add(btnExcel);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "DuAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Dự án";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDuAn).EndInit();
            ResumeLayout(false);

        }



        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUuTien;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDuAn;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label label9;
        private ComboBox cboTrangThai;
        private ComboBox cboNguoiQuanLy;
        private Label label4;
    }
}