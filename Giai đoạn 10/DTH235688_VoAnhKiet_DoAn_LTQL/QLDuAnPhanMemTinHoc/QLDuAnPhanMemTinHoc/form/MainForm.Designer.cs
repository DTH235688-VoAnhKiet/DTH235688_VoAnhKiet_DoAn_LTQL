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
            btnBug = new Button(); // 1. Khởi tạo Bug
            btnPhanCong = new Button();
            btnKhachHang = new Button();
            btnDuAn = new Button();
            btnNhanVien = new Button();
            btnTrangChu = new Button();
            btnDangXuat = new Button();
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
            panelMenu.Controls.Add(btnBug); // Thêm Bug vào menu
            panelMenu.Controls.Add(btnPhanCong);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnDuAn);
            panelMenu.Controls.Add(btnNhanVien);
            panelMenu.Controls.Add(btnTrangChu);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 589);
            panelMenu.TabIndex = 0;
            // 
            // btnBug
            // 
            btnBug.Dock = DockStyle.Top;
            btnBug.FlatAppearance.BorderSize = 0;
            btnBug.FlatStyle = FlatStyle.Flat;
            btnBug.Font = new Font("Segoe UI", 11F);
            btnBug.ForeColor = Color.Gainsboro;
            btnBug.ImageAlign = ContentAlignment.MiddleLeft;
            btnBug.Location = new Point(0, 380);
            btnBug.Name = "btnBug";
            btnBug.Padding = new Padding(12, 0, 0, 0);
            btnBug.Size = new Size(250, 60);
            btnBug.TabIndex = 5;
            btnBug.Text = "  🐞 Quản lý Bug/Lỗi";
            btnBug.TextAlign = ContentAlignment.MiddleLeft;
            btnBug.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBug.UseVisualStyleBackColor = true;
            btnBug.Click += btnBug_Click; // Liên kết hàm xử lý
            // 
            // btnPhanCong
            // 
            btnPhanCong.Dock = DockStyle.Top;
            btnPhanCong.FlatAppearance.BorderSize = 0;
            btnPhanCong.FlatStyle = FlatStyle.Flat;
            btnPhanCong.Font = new Font("Segoe UI", 11F);
            btnPhanCong.ForeColor = Color.Gainsboro;
            btnPhanCong.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhanCong.Location = new Point(0, 320);
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
            btnKhachHang.Location = new Point(0, 260);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(12, 0, 0, 0);
            btnKhachHang.Size = new Size(250, 60);
            btnKhachHang.TabIndex = 3;
            btnKhachHang.Text = "  🤝 Quản lý Khách Hàng";
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
            btnDuAn.Location = new Point(0, 200);
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
            btnNhanVien.Location = new Point(0, 140);
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
            // btnTrangChu
            // 
            btnTrangChu.Dock = DockStyle.Top;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Segoe UI", 11F);
            btnTrangChu.ForeColor = Color.Gainsboro;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 80);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Padding = new Padding(12, 0, 0, 0);
            btnTrangChu.Size = new Size(250, 60);
            btnTrangChu.TabIndex = 6;
            btnTrangChu.Text = "  🏠 Trang chủ";
            btnTrangChu.TextAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangXuat.ForeColor = Color.Tomato;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 529);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(12, 0, 0, 0);
            btnDangXuat.Size = new Size(250, 60);
            btnDangXuat.TabIndex = 7;
            btnDangXuat.Text = "  🚪 Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
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
        internal Button btnTrangChu;
        internal Button btnDangXuat;
        internal Button btnPhanCong;
        internal Button btnBug; // Đã nằm đây rồi nhé ný!
    }
}