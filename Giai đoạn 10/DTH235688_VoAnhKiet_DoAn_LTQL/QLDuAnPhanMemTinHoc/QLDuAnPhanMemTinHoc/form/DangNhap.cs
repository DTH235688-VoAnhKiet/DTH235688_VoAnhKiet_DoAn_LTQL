using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            StylizeForm();
        }

        private void StylizeForm()
        {
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            foreach (Control c in this.Controls)
            {
                StylizeControls(c);
            }
        }

        private void StylizeControls(Control parent)
        {
            if (parent is System.Windows.Forms.Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;

                string text = btn.Text.ToLower();
                if (text.Contains("đăng nhập")) btn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
                else if (text.Contains("thoát") || text.Contains("hủy")) btn.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
                else btn.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            }

            foreach (Control c in parent.Controls)
            {
                StylizeControls(c);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text.Trim();
            string pass = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vaiTro = "";
            int idDangNhap = -1;

            string strKetNoi = System.Configuration.ConfigurationManager.ConnectionStrings["QLDAConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT ID, QuyenHan FROM NhanVien WHERE TenDangNhap = @User AND MatKhau = @Pass";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", user);
                        cmd.Parameters.AddWithValue("@Pass", pass);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idDangNhap = Convert.ToInt32(reader["ID"]);
                                vaiTro = reader["QuyenHan"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
                    return;
                }
            }

            if (idDangNhap != -1)
            {
                // QuyenHan trong DB có thể trả về 'True', '1' cho Admin
                bool isAdmin = (vaiTro.ToLower() == "true" || vaiTro == "1" || vaiTro.ToLower() == "admin");
                string roleFinal = isAdmin ? "Admin" : "Nhân viên";

                MessageBox.Show($"Đăng nhập thành công với quyền {roleFinal}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                MainForm fMain = new MainForm(roleFinal, idDangNhap);

                fMain.FormClosed += (s, args) => this.Close();
                fMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

