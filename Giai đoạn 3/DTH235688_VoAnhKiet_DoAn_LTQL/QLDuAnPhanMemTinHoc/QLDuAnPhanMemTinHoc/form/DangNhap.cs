using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string vaiTro = ""; // Tui tạo sẵn biến lưu vai trò nè

            // 1. Kiểm tra nếu là Admin
            if (user == "admin" && pass == "123")
            {
                vaiTro = "Admin";
            }
            // 2. Kiểm tra nếu là Nhân viên (tài khoản để test ẩn nút)
            else if (user == "nv" && pass == "123")
            {
                vaiTro = "Nhân viên"; // Chữ "Nhân viên" này sẽ được gửi qua MainForm
            }

            // Xử lý mở form
            if (vaiTro != "")
            {
                // Mở MainForm VÀ NÉM CÁI VAI TRÒ QUA ĐÓ (Nhét biến vaiTro vô ngoặc tròn)
                MainForm fMain = new MainForm(vaiTro);
                fMain.FormClosed += (s, args) => this.Close();
                fMain.Show();
                this.Hide();
            }
            else if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Ný ơi, vui lòng nhập đầy đủ tên và mật khẩu nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

