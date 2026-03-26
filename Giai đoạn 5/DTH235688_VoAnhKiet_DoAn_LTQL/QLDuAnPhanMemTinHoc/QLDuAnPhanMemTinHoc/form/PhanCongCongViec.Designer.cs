namespace QLDuAnPhanMemTinHoc.form
{
    partial class PhanCongCongViec
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
            gbInfo = new GroupBox();
            lblDA = new Label();
            cboDuAn = new ComboBox();
            lblNV = new Label();
            cboNhanVien = new ComboBox();
            lblTask = new Label();
            txtTenCongViec = new TextBox();
            lblStart = new Label();
            dtpStart = new DateTimePicker();
            lblEnd = new Label();
            dtpEnd = new DateTimePicker();
            lblStatus = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            dgvPhanCong = new DataGridView();
            txtTimKiem = new TextBox();
            btnSearch = new Button();
            lblSearch = new Label();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).BeginInit();
            SuspendLayout();
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lblDA);
            gbInfo.Controls.Add(cboDuAn);
            gbInfo.Controls.Add(lblNV);
            gbInfo.Controls.Add(cboNhanVien);
            gbInfo.Controls.Add(lblTask);
            gbInfo.Controls.Add(txtTenCongViec);
            gbInfo.Controls.Add(lblStart);
            gbInfo.Controls.Add(dtpStart);
            gbInfo.Controls.Add(lblEnd);
            gbInfo.Controls.Add(dtpEnd);
            gbInfo.Controls.Add(lblStatus);
            gbInfo.Controls.Add(cboTrangThai);
            gbInfo.Font = new Font("Segoe UI", 9F);
            gbInfo.Location = new Point(14, 16);
            gbInfo.Margin = new Padding(3, 4, 3, 4);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(3, 4, 3, 4);
            gbInfo.Size = new Size(1097, 187);
            gbInfo.TabIndex = 10;
            gbInfo.TabStop = false;
            gbInfo.Text = "Thông tin phân công";
            // 
            // lblDA
            // 
            lblDA.Location = new Point(23, 40);
            lblDA.Name = "lblDA";
            lblDA.Size = new Size(114, 31);
            lblDA.TabIndex = 0;
            lblDA.Text = "Dự án:";
            // 
            // cboDuAn
            // 
            cboDuAn.Location = new Point(143, 36);
            cboDuAn.Margin = new Padding(3, 4, 3, 4);
            cboDuAn.Name = "cboDuAn";
            cboDuAn.Size = new Size(348, 28);
            cboDuAn.TabIndex = 1;
            // 
            // lblNV
            // 
            lblNV.Location = new Point(23, 87);
            lblNV.Name = "lblNV";
            lblNV.Size = new Size(114, 31);
            lblNV.TabIndex = 2;
            lblNV.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.Location = new Point(143, 83);
            cboNhanVien.Margin = new Padding(3, 4, 3, 4);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(348, 28);
            cboNhanVien.TabIndex = 3;
            // 
            // lblTask
            // 
            lblTask.Location = new Point(23, 133);
            lblTask.Name = "lblTask";
            lblTask.Size = new Size(114, 31);
            lblTask.TabIndex = 4;
            lblTask.Text = "Nhiệm vụ:";
            // 
            // txtTenCongViec
            // 
            txtTenCongViec.Location = new Point(143, 129);
            txtTenCongViec.Margin = new Padding(3, 4, 3, 4);
            txtTenCongViec.Name = "txtTenCongViec";
            txtTenCongViec.Size = new Size(348, 27);
            txtTenCongViec.TabIndex = 5;
            // 
            // lblStart
            // 
            lblStart.Location = new Point(549, 40);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(114, 31);
            lblStart.TabIndex = 6;
            lblStart.Text = "Ngày bắt đầu:";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(663, 36);
            dtpStart.Margin = new Padding(3, 4, 3, 4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(365, 27);
            dtpStart.TabIndex = 7;
            // 
            // lblEnd
            // 
            lblEnd.Location = new Point(549, 87);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(114, 31);
            lblEnd.TabIndex = 8;
            lblEnd.Text = "Hạn chót:";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(663, 83);
            dtpEnd.Margin = new Padding(3, 4, 3, 4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(365, 27);
            dtpEnd.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(549, 133);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(114, 31);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.Location = new Point(663, 129);
            cboTrangThai.Margin = new Padding(3, 4, 3, 4);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(365, 28);
            cboTrangThai.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(14, 220);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(97, 40);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm mới";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(214, 220);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(97, 40);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(414, 220);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(97, 40);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(614, 220);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(97, 40);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(814, 220);
            btnHuy.Margin = new Padding(3, 4, 3, 4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(97, 40);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "Hủy bỏ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1014, 220);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(97, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // dgvPhanCong
            // 
            dgvPhanCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhanCong.BackgroundColor = SystemColors.ControlLightLight;
            dgvPhanCong.ColumnHeadersHeight = 29;
            dgvPhanCong.Location = new Point(14, 327);
            dgvPhanCong.Margin = new Padding(3, 4, 3, 4);
            dgvPhanCong.Name = "dgvPhanCong";
            dgvPhanCong.RowHeadersWidth = 51;
            dgvPhanCong.Size = new Size(1097, 242);
            dgvPhanCong.TabIndex = 3;
            dgvPhanCong.CellClick += dgvPhanCong_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(728, 284);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(251, 27);
            txtTimKiem.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(994, 281);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 33);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(617, 287);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(114, 31);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm kiếm:";
            // 
            // PhanCongCongViec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 601);
            Controls.Add(lblSearch);
            Controls.Add(btnSearch);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvPhanCong);
            Controls.Add(btnThoat);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(gbInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PhanCongCongViec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phân Công Công Việc";
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblDA;
        private System.Windows.Forms.ComboBox cboDuAn;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
    }


}
