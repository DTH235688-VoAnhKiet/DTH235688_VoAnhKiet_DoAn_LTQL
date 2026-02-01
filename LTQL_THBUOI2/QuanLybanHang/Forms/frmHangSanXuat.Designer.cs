namespace QuanLybanHang.Forms
{
    partial class frmHangSanXuat
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
            txttenhangsanxuat = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvdanhsachhang = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Tenhangsanxuat = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachhang).BeginInit();
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
            groupBox1.Controls.Add(txttenhangsanxuat);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F);
            groupBox1.Location = new Point(12, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(911, 191);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hãng sản xuất";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(427, 101);
            btnxoa.Margin = new Padding(3, 4, 3, 4);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(86, 31);
            btnxoa.TabIndex = 4;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(799, 101);
            btnthoat.Margin = new Padding(3, 4, 3, 4);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(86, 31);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnhuybo
            // 
            btnhuybo.Location = new Point(675, 101);
            btnhuybo.Margin = new Padding(3, 4, 3, 4);
            btnhuybo.Name = "btnhuybo";
            btnhuybo.Size = new Size(86, 31);
            btnhuybo.TabIndex = 6;
            btnhuybo.Text = "Hủy bỏ";
            btnhuybo.UseVisualStyleBackColor = true;
            btnhuybo.Click += btnhuybo_Click;
            // 
            // btnluu
            // 
            btnluu.Location = new Point(549, 101);
            btnluu.Margin = new Padding(3, 4, 3, 4);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(86, 31);
            btnluu.TabIndex = 5;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = true;
            btnluu.Click += btnluu_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(293, 101);
            btnsua.Margin = new Padding(3, 4, 3, 4);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(86, 31);
            btnsua.TabIndex = 3;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(165, 101);
            btnthem.Margin = new Padding(3, 4, 3, 4);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(86, 31);
            btnthem.TabIndex = 2;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // txttenhangsanxuat
            // 
            txttenhangsanxuat.Location = new Point(165, 45);
            txttenhangsanxuat.Margin = new Padding(3, 4, 3, 4);
            txttenhangsanxuat.Name = "txttenhangsanxuat";
            txttenhangsanxuat.Size = new Size(719, 27);
            txttenhangsanxuat.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 50);
            label1.Name = "label1";
            label1.Size = new Size(137, 17);
            label1.TabIndex = 0;
            label1.Text = "Tên hãng sản xuất (*)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvdanhsachhang);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(12, 202);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(911, 393);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hãng sản xuất";
            // 
            // dgvdanhsachhang
            // 
            dgvdanhsachhang.AllowUserToAddRows = false;
            dgvdanhsachhang.AllowUserToDeleteRows = false;
            dgvdanhsachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdanhsachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdanhsachhang.Columns.AddRange(new DataGridViewColumn[] { ID, Tenhangsanxuat });
            dgvdanhsachhang.Dock = DockStyle.Fill;
            dgvdanhsachhang.Location = new Point(3, 24);
            dgvdanhsachhang.Margin = new Padding(3, 4, 3, 4);
            dgvdanhsachhang.MultiSelect = false;
            dgvdanhsachhang.Name = "dgvdanhsachhang";
            dgvdanhsachhang.RowHeadersWidth = 51;
            dgvdanhsachhang.Size = new Size(905, 365);
            dgvdanhsachhang.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Tenhangsanxuat
            // 
            Tenhangsanxuat.DataPropertyName = "Tenhangsanxuat";
            Tenhangsanxuat.HeaderText = "Tên Hãng Sản Xuất";
            Tenhangsanxuat.MinimumWidth = 6;
            Tenhangsanxuat.Name = "Tenhangsanxuat";
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 596);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            Margin = new Padding(4);
            Name = "frmHangSanXuat";
            Text = "frmHangSanXuat";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvdanhsachhang).EndInit();
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
        private TextBox txttenhangsanxuat;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvdanhsachhang;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Tenhangsanxuat;
    }
}