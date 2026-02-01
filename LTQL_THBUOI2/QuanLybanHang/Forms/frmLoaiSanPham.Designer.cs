namespace QuanLybanHang.Forms
{
    partial class frmLoaiSanPham
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
            btnxoa = new Button();
            btnthoat = new Button();
            btnhuybo = new Button();
            btnluu = new Button();
            btnsua = new Button();
            btnthem = new Button();
            txttenloai = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvdanhsachloai = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachloai).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnxoa);
            groupBox1.Controls.Add(btnthoat);
            groupBox1.Controls.Add(btnhuybo);
            groupBox1.Controls.Add(btnluu);
            groupBox1.Controls.Add(btnsua);
            groupBox1.Controls.Add(btnthem);
            groupBox1.Controls.Add(txttenloai);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(374, 76);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(75, 23);
            btnxoa.TabIndex = 4;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(699, 76);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnhuybo
            // 
            btnhuybo.Location = new Point(591, 76);
            btnhuybo.Name = "btnhuybo";
            btnhuybo.Size = new Size(75, 23);
            btnhuybo.TabIndex = 6;
            btnhuybo.Text = "Hủy bỏ";
            btnhuybo.UseVisualStyleBackColor = true;
            btnhuybo.Click += btnhuybo_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(480, 76);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(75, 23);
            btnluu.TabIndex = 5;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(256, 76);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(75, 23);
            btnsua.TabIndex = 3;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(144, 76);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 23);
            btnthem.TabIndex = 2;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txttenloai
            // 
            txttenloai.Location = new Point(144, 34);
            txttenloai.Name = "txttenloai";
            txttenloai.Size = new Size(630, 23);
            txttenloai.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên loại sản phẩm(*():";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvdanhsachloai);
            groupBox2.Location = new Point(2, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(797, 295);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "danh sách loại sản phẩm";
            // 
            // dgvdanhsachloai
            // 
            dgvdanhsachloai.AllowUserToAddRows = false;
            dgvdanhsachloai.AllowUserToDeleteRows = false;
            dgvdanhsachloai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdanhsachloai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhsachloai.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai });
            dgvdanhsachloai.Dock = DockStyle.Fill;
            dgvdanhsachloai.Location = new Point(3, 19);
            dgvdanhsachloai.MultiSelect = false;
            dgvdanhsachloai.Name = "dgvdanhsachloai";
            dgvdanhsachloai.Size = new Size(791, 273);
            dgvdanhsachloai.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Tên Loại Sản Phẩm";
            TenLoai.Name = "TenLoai";
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmLoaiSanPham";
            Text = "frmLoaiSanPham";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachloai).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnxoa;
        private Button btnthoat;
        private Button btnhuybo;
        private Button btnluu;
        private Button btnsua;
        private Button btnthem;
        private TextBox txttenloai;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvdanhsachloai;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
    }
}