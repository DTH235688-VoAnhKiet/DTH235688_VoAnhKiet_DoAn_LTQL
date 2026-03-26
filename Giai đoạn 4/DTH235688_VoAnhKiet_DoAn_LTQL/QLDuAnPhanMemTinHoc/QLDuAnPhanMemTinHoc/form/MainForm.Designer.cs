namespace QLDuAnPhanMemTinHoc.form
{
    partial class MainForm
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
            panelMenu = new Panel();
            btnPhanCong = new Button();
            btnKhachHang = new Button();
            btnDuAn = new Button();
            btnNhanVien = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnPhanCong);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnDuAn);
            panelMenu.Controls.Add(btnNhanVien);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 589);
            panelMenu.TabIndex = 0;
            // 
            // btnPhanCong
            // 
            btnPhanCong.Dock = DockStyle.Top;
            btnPhanCong.FlatAppearance.BorderSize = 0;
            btnPhanCong.FlatStyle = FlatStyle.Flat;
            btnPhanCong.Font = new Font("Segoe UI", 11F);
            btnPhanCong.ForeColor = Color.Gainsboro;
            btnPhanCong.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhanCong.Location = new Point(0, 260);
            btnPhanCong.Name = "btnPhanCong";
            btnPhanCong.Padding = new Padding(12, 0, 0, 0);
            btnPhanCong.Size = new Size(250, 60);
            btnPhanCong.TabIndex = 4;
            btnPhanCong.Text = "  📝 Phân công công việc";
            btnPhanCong.TextAlign = ContentAlignment.MiddleLeft;
            btnPhanCong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhanCong.UseVisualStyleBackColor = true;
            btnPhanCong.Click += btnPhanCong_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 11F);
            btnKhachHang.ForeColor = Color.Gainsboro;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 200);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(12, 0, 0, 0);
            btnKhachHang.Size = new Size(250, 60);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "  \U0001f91d Quản lý Khách Hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnDuAn
            // 
            btnDuAn.Dock = DockStyle.Top;
            btnDuAn.FlatAppearance.BorderSize = 0;
            btnDuAn.FlatStyle = FlatStyle.Flat;
            btnDuAn.Font = new Font("Segoe UI", 11F);
            btnDuAn.ForeColor = Color.Gainsboro;
            btnDuAn.ImageAlign = ContentAlignment.MiddleLeft;
            btnDuAn.Location = new Point(0, 140);
            btnDuAn.Name = "btnDuAn";
            btnDuAn.Padding = new Padding(12, 0, 0, 0);
            btnDuAn.Size = new Size(250, 60);
            btnDuAn.TabIndex = 2;
            btnDuAn.Text = "  📁 Quản lý Dự Án";
            btnDuAn.TextAlign = ContentAlignment.MiddleLeft;
            btnDuAn.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDuAn.UseVisualStyleBackColor = true;
            btnDuAn.Click += btnDuAn_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 11F);
            btnNhanVien.ForeColor = Color.Gainsboro;
            btnNhanVien.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.Location = new Point(0, 80);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(12, 0, 0, 0);
            btnNhanVien.Size = new Size(250, 60);
            btnNhanVien.TabIndex = 1;
            btnNhanVien.Text = "  👤 Quản lý Nhân Viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhanVien.UseVisualStyleBackColor = true;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 80);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLogo.ForeColor = Color.LightGray;
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(250, 80);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "IT PROJECT MGR";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.WhiteSmoke;
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(950, 589);
            panelDesktop.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 589);
            Controls.Add(panelDesktop);
            Controls.Add(panelMenu);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Dự Án";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ResumeLayout(false);



        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelDesktop;
        internal Button btnKhachHang;
        internal Button btnDuAn;
        internal Button btnNhanVien;
        internal Button btnPhanCong;
    }
}