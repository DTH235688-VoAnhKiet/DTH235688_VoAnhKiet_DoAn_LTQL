namespace QLDuAnPhanMemTinHoc.form
{
    partial class TrangChu
    {
        private System.Windows.Forms.Label lblLoiChao;
        private System.Windows.Forms.Label lblSubText;
        private System.Windows.Forms.FlowLayoutPanel flowPanelThongKe;
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
            this.lblLoiChao = new System.Windows.Forms.Label();
            this.lblSubText = new System.Windows.Forms.Label();
            this.flowPanelThongKe = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();

            // lblLoiChao
            this.lblLoiChao.AutoSize = true;
            this.lblLoiChao.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblLoiChao.Location = new System.Drawing.Point(30, 30);
            this.lblLoiChao.Name = "lblLoiChao";
            this.lblLoiChao.Size = new System.Drawing.Size(300, 40);
            this.lblLoiChao.Text = "XIN CHÀO!";

            // lblSubText
            this.lblSubText.AutoSize = true;
            this.lblSubText.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubText.ForeColor = System.Drawing.Color.Gray;
            this.lblSubText.Location = new System.Drawing.Point(35, 80);
            this.lblSubText.Name = "lblSubText";
            this.lblSubText.Size = new System.Drawing.Size(400, 20);
            this.lblSubText.Text = "Hệ thống quản lý dự án phần mềm tin học.";

            // flowPanelThongKe (Cái này để chứa các thẻ cho nó tự ngay hàng)
            this.flowPanelThongKe.Location = new System.Drawing.Point(30, 140);
            this.flowPanelThongKe.Name = "flowPanelThongKe";
            this.flowPanelThongKe.Size = new System.Drawing.Size(1000, 160);

            // TrangChu Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1100, 850);
            this.Controls.Add(this.flowPanelThongKe);
            this.Controls.Add(this.lblSubText);
            this.Controls.Add(this.lblLoiChao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Bỏ viền cho đẹp khi lồng vào MainForm
            this.Name = "TrangChu";
            this.Text = "Trang Chủ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion
    }
}