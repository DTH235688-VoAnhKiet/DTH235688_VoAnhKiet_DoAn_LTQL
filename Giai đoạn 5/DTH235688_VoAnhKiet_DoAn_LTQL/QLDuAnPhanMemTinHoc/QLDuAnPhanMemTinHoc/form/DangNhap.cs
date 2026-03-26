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
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTenDangNhap.Text.Trim();
            string pass = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Ný ơi, vui lòng nhập đầy đủ tên và mật khẩu nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vaiTro = "";
            int idDangNhap = -1; // Biến này cực quan trọng để hứng ID nè

            // Dán cái chuỗi kết nối của ný vô đây nha (giống bên form CongViecCuaToi á)
            string strKetNoi = "Data Source=DESKTOP-AH4SISS\\SQLEXPRESS;Initial Catalog=QLDA;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(strKetNoi))
            {
                try
                {
                    conn.Open();
                    // Câu SQL thần thánh: Tìm nhân viên có User và Pass khớp với ný nhập
                    string sql = "SELECT ID, QuyenHan FROM NhanVien WHERE TenDangNhap = @User AND MatKhau = @Pass";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@User", user);
                        cmd.Parameters.AddWithValue("@Pass", pass);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Nếu đọc được dữ liệu (tức là đăng nhập đúng)
                            {
                                idDangNhap = Convert.ToInt32(reader["ID"]); // Chộp ngay cái ID
                                vaiTro = reader["QuyenHan"].ToString();     // Chộp luôn cái quyền
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

            // Xử lý sau khi check SQL xong
            if (idDangNhap != -1) // Có ID tức là đăng nhập thành công
            {
                MessageBox.Show($"Đăng nhập thành công! Chào {vaiTro} nha.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Dữ liệu quyền ný đang cầm là: " + vaiTro);
                // MỞ MAINFORM VÀ NÉM CẢ "VAI TRÒ" LẪN "ID" QUA ĐÓ LUÔN
                MainForm fMain = new MainForm(vaiTro, idDangNhap);

                fMain.FormClosed += (s, args) => this.Close();
                fMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu rồi ný!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Ný chắc chắn muốn thoát chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

