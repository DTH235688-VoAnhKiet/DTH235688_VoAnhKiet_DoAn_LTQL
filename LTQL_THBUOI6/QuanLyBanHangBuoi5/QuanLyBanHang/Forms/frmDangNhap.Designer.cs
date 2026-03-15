namespace QuanLyBanHang.Forms
{
    partial class frmDangNhap
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
            txtTenDangNhap = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            btnHuyBo = new Button();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(312, 115);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(352, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 92);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 154);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(312, 177);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '⚫';
            txtMatKhau.Size = new Size(352, 27);
            txtMatKhau.TabIndex = 3;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(314, 228);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(123, 29);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(540, 228);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(123, 29);
            btnHuyBo.TabIndex = 5;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 343);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTenDangNhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtTenDangNhap;
        private Label label1;
        private Label label2;
        public TextBox txtMatKhau;
        private Button btnDangNhap;
        private Button btnHuyBo;
    }
}