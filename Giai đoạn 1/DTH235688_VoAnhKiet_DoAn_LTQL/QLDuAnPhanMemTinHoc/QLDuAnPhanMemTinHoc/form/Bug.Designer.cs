namespace QLDuAnPhanMemTinHoc.form
{
    partial class Bug
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
            groupBox1 = new GroupBox();
            txtMoTa = new TextBox();
            label8 = new Label();
            dtpNgayBao = new DateTimePicker();
            label7 = new Label();
            cboTrangThai = new ComboBox();
            label6 = new Label();
            cboMucDo = new ComboBox();
            label5 = new Label();
            cboNguoiXuLy = new ComboBox();
            label4 = new Label();
            cboDuAn = new ComboBox();
            label3 = new Label();
            txtTenLoi = new TextBox();
            label2 = new Label();
            txtMaLoi = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            groupBox2 = new GroupBox();
            dgvLoi = new DataGridView();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label11 = new Label();
            cboLocTrangThai = new ComboBox();
            label10 = new Label();
            cboLocDuAn = new ComboBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpNgayBao);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboTrangThai);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboMucDo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboNguoiXuLy);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboDuAn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTenLoi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMaLoi);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1120, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Bug / Lỗi";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(617, 149);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(479, 83);
            txtMoTa.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(488, 153);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 14;
            label8.Text = "Mô tả / Tái hiện";
            // 
            // dtpNgayBao
            // 
            dtpNgayBao.Format = DateTimePickerFormat.Short;
            dtpNgayBao.Location = new Point(949, 43);
            dtpNgayBao.Margin = new Padding(3, 4, 3, 4);
            dtpNgayBao.Name = "dtpNgayBao";
            dtpNgayBao.Size = new Size(148, 27);
            dtpNgayBao.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(869, 47);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 12;
            label7.Text = "Ngày báo";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Mới tạo (Open)", "Đang sửa (In Progress)", "Đã sửa (Resolved)", "Đóng (Closed)" });
            cboTrangThai.Location = new Point(617, 96);
            cboTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(228, 28);
            cboTrangThai.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 100);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 10;
            label6.Text = "Trạng thái";
            // 
            // cboMucDo
            // 
            cboMucDo.FormattingEnabled = true;
            cboMucDo.Items.AddRange(new object[] { "Thấp", "Trung bình", "Nghiêm trọng", "Crash hệ thống" });
            cboMucDo.Location = new Point(617, 43);
            cboMucDo.Margin = new Padding(3, 4, 3, 4);
            cboMucDo.Name = "cboMucDo";
            cboMucDo.Size = new Size(228, 28);
            cboMucDo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 46);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 8;
            label5.Text = "Mức độ (Severity)";
            label5.Click += label5_Click;
            // 
            // cboNguoiXuLy
            // 
            cboNguoiXuLy.FormattingEnabled = true;
            cboNguoiXuLy.Location = new Point(137, 203);
            cboNguoiXuLy.Margin = new Padding(3, 4, 3, 4);
            cboNguoiXuLy.Name = "cboNguoiXuLy";
            cboNguoiXuLy.Size = new Size(319, 28);
            cboNguoiXuLy.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 207);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 6;
            label4.Text = "Người fix lỗi";
            // 
            // cboDuAn
            // 
            cboDuAn.FormattingEnabled = true;
            cboDuAn.Location = new Point(137, 149);
            cboDuAn.Margin = new Padding(3, 4, 3, 4);
            cboDuAn.Name = "cboDuAn";
            cboDuAn.Size = new Size(319, 28);
            cboDuAn.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 153);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Dự án";
            // 
            // txtTenLoi
            // 
            txtTenLoi.Location = new Point(137, 96);
            txtTenLoi.Margin = new Padding(3, 4, 3, 4);
            txtTenLoi.Name = "txtTenLoi";
            txtTenLoi.Size = new Size(319, 27);
            txtTenLoi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 100);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Tiêu đề (*)";
            // 
            // txtMaLoi
            // 
            txtMaLoi.Location = new Point(137, 43);
            txtMaLoi.Margin = new Padding(3, 4, 3, 4);
            txtMaLoi.Name = "txtMaLoi";
            txtMaLoi.ReadOnly = true;
            txtMaLoi.Size = new Size(319, 27);
            txtMaLoi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã lỗi";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(18, 340);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(97, 47);
            btnThem.TabIndex = 1;
            btnThem.Text = "Báo lỗi mới";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(221, 340);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(97, 47);
            btnSua.TabIndex = 2;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(424, 340);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(97, 47);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(627, 340);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(97, 47);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(830, 340);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(97, 47);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy bỏ";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1033, 340);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 47);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvLoi);
            groupBox2.Controls.Add(btnTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(cboLocTrangThai);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(cboLocDuAn);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(14, 407);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1120, 366);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách Bug / Lỗi";
            // 
            // dgvLoi
            // 
            dgvLoi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoi.Location = new Point(23, 93);
            dgvLoi.Margin = new Padding(3, 4, 3, 4);
            dgvLoi.Name = "dgvLoi";
            dgvLoi.RowHeadersWidth = 51;
            dgvLoi.Size = new Size(1074, 218);
            dgvLoi.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(880, 41);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(86, 33);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(640, 43);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(228, 27);
            txtTimKiem.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(549, 47);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 4;
            label11.Text = "Tìm tiêu đề:";
            // 
            // cboLocTrangThai
            // 
            cboLocTrangThai.FormattingEnabled = true;
            cboLocTrangThai.Items.AddRange(new object[] { "Tất cả", "Mới tạo", "Đang sửa", "Đã sửa", "Đóng" });
            cboLocTrangThai.Location = new Point(377, 43);
            cboLocTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboLocTrangThai.Name = "cboLocTrangThai";
            cboLocTrangThai.Size = new Size(137, 28);
            cboLocTrangThai.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(297, 47);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 2;
            label10.Text = "Trạng thái:";
            // 
            // cboLocDuAn
            // 
            cboLocDuAn.FormattingEnabled = true;
            cboLocDuAn.Location = new Point(103, 43);
            cboLocDuAn.Margin = new Padding(3, 4, 3, 4);
            cboLocDuAn.Name = "cboLocDuAn";
            cboLocDuAn.Size = new Size(171, 28);
            cboLocDuAn.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 47);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 0;
            label9.Text = "Lọc dự án:";
            // 
            // Bug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 841);
            Controls.Add(groupBox2);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bug";
            Text = "Quản lý Lỗi (Bug Tracker)";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoi).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDuAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNguoiXuLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMucDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpNgayBao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboLocDuAn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvLoi;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion


    }
}

   
