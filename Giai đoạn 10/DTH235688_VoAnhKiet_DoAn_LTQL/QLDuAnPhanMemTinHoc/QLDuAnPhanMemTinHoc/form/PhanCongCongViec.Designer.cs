namespace QLDuAnPhanMemTinHoc.form
{
    partial class PhanCongCongViec
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
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.tlpInput = new System.Windows.Forms.TableLayoutPanel();
            this.lblDA = new System.Windows.Forms.Label();
            this.cboDuAn = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.txtTenCongViec = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tlpTimKiem = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPhanCong = new System.Windows.Forms.DataGridView();
            
            this.gbInfo.SuspendLayout();
            this.tlpInput.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tlpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInfo.Controls.Add(this.tlpInput);

            this.gbInfo.Location = new System.Drawing.Point(14, 16);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
            this.gbInfo.Size = new System.Drawing.Size(1097, 150);
            this.gbInfo.TabIndex = 10;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Thông tin chi tiết phân công";
            // 
            // tlpInput
            // 
            this.tlpInput.ColumnCount = 6;
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpInput.Controls.Add(this.lblDA, 0, 0);
            this.tlpInput.Controls.Add(this.cboDuAn, 1, 0);
            this.tlpInput.Controls.Add(this.lblNV, 2, 0);
            this.tlpInput.Controls.Add(this.cboNhanVien, 3, 0);
            this.tlpInput.Controls.Add(this.lblTask, 4, 0);
            this.tlpInput.Controls.Add(this.txtTenCongViec, 5, 0);
            this.tlpInput.Controls.Add(this.lblStart, 0, 1);
            this.tlpInput.Controls.Add(this.dtpStart, 1, 1);
            this.tlpInput.Controls.Add(this.lblEnd, 2, 1);
            this.tlpInput.Controls.Add(this.dtpEnd, 3, 1);
            this.tlpInput.Controls.Add(this.lblStatus, 4, 1);
            this.tlpInput.Controls.Add(this.cboTrangThai, 5, 1);
            this.tlpInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInput.Location = new System.Drawing.Point(15, 49);
            this.tlpInput.Name = "tlpInput";
            this.tlpInput.RowCount = 2;
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInput.Size = new System.Drawing.Size(1067, 86);
            this.tlpInput.TabIndex = 0;
            // 
            // lblDA
            // 
            this.lblDA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(3, 26);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(74, 30);
            this.lblDA.TabIndex = 0;
            this.lblDA.Text = "Dự án:";
            // 
            // cboDuAn
            // 
            this.cboDuAn.Dock = System.Windows.Forms.DockStyle.Fill;

            this.cboDuAn.Location = new System.Drawing.Point(95, 8);
            this.cboDuAn.Margin = new System.Windows.Forms.Padding(3, 8, 20, 3);
            this.cboDuAn.Name = "cboDuAn";
            this.cboDuAn.Size = new System.Drawing.Size(260, 36);
            this.cboDuAn.TabIndex = 1;
            // 
            // lblNV
            // 
            this.lblNV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(371, 26);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(116, 30);
            this.lblNV.TabIndex = 2;
            this.lblNV.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;

            this.cboNhanVien.Location = new System.Drawing.Point(493, 8);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(3, 8, 20, 3);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(260, 36);
            this.cboNhanVien.TabIndex = 3;
            // 
            // lblTask
            // 
            this.lblTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(767, 26);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(112, 30);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Nhiệm vụ:";
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtTenCongViec.Location = new System.Drawing.Point(885, 8);
            this.txtTenCongViec.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(179, 34);
            this.txtTenCongViec.TabIndex = 5;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(3, 109);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(86, 30);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Hạn BĐ:";
            // 
            // dtpStart
            // 
            this.dtpStart.Dock = System.Windows.Forms.DockStyle.Fill;

            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(95, 51);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 8, 20, 3);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(260, 34);
            this.dtpStart.TabIndex = 7;
            // 
            // lblEnd
            // 
            this.lblEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(371, 109);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(88, 30);
            this.lblEnd.TabIndex = 8;
            this.lblEnd.Text = "Hạn KT:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Dock = System.Windows.Forms.DockStyle.Fill;

            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(493, 51);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 8, 20, 3);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(260, 34);
            this.dtpEnd.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(767, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(112, 30);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Dock = System.Windows.Forms.DockStyle.Fill;

            this.cboTrangThai.Location = new System.Drawing.Point(885, 51);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(179, 36);
            this.cboTrangThai.TabIndex = 11;
            // 
            // tlpButtons
            // 
            this.tlpButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtons.ColumnCount = 6;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpButtons.Controls.Add(this.btnThem, 0, 0);
            this.tlpButtons.Controls.Add(this.btnSua, 1, 0);
            this.tlpButtons.Controls.Add(this.btnXoa, 2, 0);
            this.tlpButtons.Controls.Add(this.btnLuu, 3, 0);
            this.tlpButtons.Controls.Add(this.btnHuy, 4, 0);
            this.tlpButtons.Controls.Add(this.btnThoat, 5, 0);
            this.tlpButtons.Location = new System.Drawing.Point(14, 180);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(1097, 50);
            this.tlpButtons.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnThem.Location = new System.Drawing.Point(20, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 40);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnSua.Location = new System.Drawing.Point(202, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 40);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnXoa.Location = new System.Drawing.Point(384, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 40);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnLuu.Location = new System.Drawing.Point(566, 5);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(142, 40);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnHuy.Location = new System.Drawing.Point(748, 5);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(142, 40);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy bỏ";
            // 
            // btnThoat
            // 
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnThoat.Location = new System.Drawing.Point(930, 5);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(147, 40);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tlpTimKiem);
            this.groupBox2.Controls.Add(this.dgvPhanCong);

            this.groupBox2.Location = new System.Drawing.Point(14, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(15, 20, 15, 15);
            this.groupBox2.Size = new System.Drawing.Size(1097, 335);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phân công";
            // 
            // tlpTimKiem
            // 
            this.tlpTimKiem.ColumnCount = 4;
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpTimKiem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTimKiem.Controls.Add(this.lblSearch, 0, 0);
            this.tlpTimKiem.Controls.Add(this.txtTimKiem, 1, 0);
            this.tlpTimKiem.Controls.Add(this.btnSearch, 2, 0);
            this.tlpTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTimKiem.Location = new System.Drawing.Point(15, 49);
            this.tlpTimKiem.Name = "tlpTimKiem";
            this.tlpTimKiem.RowCount = 1;
            this.tlpTimKiem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpTimKiem.Size = new System.Drawing.Size(1067, 40);
            this.tlpTimKiem.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(3, 5);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(105, 30);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;

            this.txtTimKiem.Location = new System.Drawing.Point(116, 5);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 5, 20, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(340, 34);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;

            this.btnSearch.Location = new System.Drawing.Point(461, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhanCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanCong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanCong.Location = new System.Drawing.Point(15, 115);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.Size = new System.Drawing.Size(1067, 205);
            this.dgvPhanCong.TabIndex = 3;
            this.dgvPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhanCong_CellClick);
            // 
            // PhanCongCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 601);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tlpButtons);
            this.Controls.Add(this.gbInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "PhanCongCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phân Công Công Việc";
            this.gbInfo.ResumeLayout(false);
            this.tlpInput.ResumeLayout(false);
            this.tlpInput.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tlpTimKiem.ResumeLayout(false);
            this.tlpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.TableLayoutPanel tlpInput;
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
        
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tlpTimKiem;
        private System.Windows.Forms.DataGridView dgvPhanCong;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}
