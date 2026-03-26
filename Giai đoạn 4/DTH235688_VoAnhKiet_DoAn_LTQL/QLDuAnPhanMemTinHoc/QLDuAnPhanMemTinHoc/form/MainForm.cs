using QLDuAnPhanMemTinHoc.Data;
using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class MainForm : Form
    {
        // Biến lưu trữ form con đang được mở
        private Form activeForm = null;
        private string quyenHan = "";
        private int idDangNhap = 1;

        public MainForm(string vaiTro, int idDuocTruyenVao)
        {

            InitializeComponent();
            this.quyenHan = vaiTro;
            this.idDangNhap = idDuocTruyenVao;
            PhanQuyenGiaoDien();

        }


        private void PhanQuyenGiaoDien()
        {
            // Chuyển về chữ thường để so sánh cả "true", "1", "false", "0"
            string role = this.quyenHan.Trim().ToLower();

            // ADMIN: Nếu là "true" (như cái MessageBox hiện ra) HOẶC là "1"
            if (role == "true" || role == "1")
            {
                // HIỆN HẾT CHO ADMIN
                btnNhanVien.Visible = true;
                btnKhachHang.Visible = true;
                btnDuAn.Visible = true;
                btnPhanCong.Text = "📋 Phân công công việc";
            }
            else
            {
                // NHÂN VIÊN: Nếu là "false" hoặc "0"
                btnNhanVien.Visible = false;
                btnKhachHang.Visible = false;
                btnDuAn.Visible = false;
                btnPhanCong.Text = "📝 Công việc của tôi";
            }
        }



        // Hàm này là "phép thuật" để nhét Form con vào Form cha
        private void OpenChildForm(Form childForm)
        {
            // Nếu có form nào đang mở thì đóng nó lại trước
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false; // Bỏ đặc quyền Form độc lập đi
            childForm.FormBorderStyle = FormBorderStyle.None; // Xóa viền của Form con
            childForm.Dock = DockStyle.Fill; // Phóng to form con cho vừa khít khu vực bên phải

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(childForm); // Thêm form con vào panel bên phải
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); // Hiển thị ra

        }

        // --- CÁC NÚT BẤM BÊN MENU ---

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DuAn());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {

            OpenChildForm(new KhachHang());
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            string role = this.quyenHan.Trim().ToLower();

            if (role == "true" || role == "1") // Nếu là ADMIN
            {
                // Mở form sếp đi giao việc
                OpenChildForm(new QLDuAnPhanMemTinHoc.form.PhanCongCongViec(this.quyenHan));
            }
            else // Nếu là NHÂN VIÊN
            {
                // Mở form nhân viên cập nhật tiến độ
                OpenChildForm(new QLDuAnPhanMemTinHoc.form.CongViecCuaToi(this.idDangNhap));
            }

        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CongViecCuaToi(this.idDangNhap));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string tenVaiTro = (this.quyenHan == "1") ? "Admin" : "Nhân viên";
            OpenChildForm(new QLDuAnPhanMemTinHoc.form.TrangChu(tenVaiTro));
            OpenChildForm(new QLDuAnPhanMemTinHoc.form.TrangChu(this.quyenHan));
        }


    }
}