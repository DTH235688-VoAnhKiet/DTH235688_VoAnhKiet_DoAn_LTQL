using QLDuAnPhanMemTinHoc.Data;
using System;
using System.Windows.Forms;

namespace QLDuAnPhanMemTinHoc.form
{
    public partial class MainForm : Form
    {
        // Biến lưu trữ form con đang được mở
        private Form activeForm = null;
        private string quyenHan = "";

        public MainForm(string vaiTro)
        {

            InitializeComponent();
            this.quyenHan = vaiTro;
            PhanQuyenGiaoDien();

        }


        private void PhanQuyenGiaoDien()
        {
            if (quyenHan == "Nhân viên")
            {
                // Nếu là nhân viên, ẨN các nút quản lý hệ thống đi
                btnNhanVien.Visible = false; // Ẩn nút QL Nhân Viên
                btnKhachHang.Visible = false; // Ẩn nút QL Khách Hàng

                // THÊM DÒNG NÀY: Ẩn luôn nút QL Dự án
                btnDuAn.Visible = false;

                // Giữ lại nút Phân công công việc cho nhân viên coi
            }
            else if (quyenHan == "Admin")
            {
                // Admin thì full quyền, chả cần ẩn gì, hiển thị hết!
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
            // Mở form phân công (Giai đoạn 6)
            OpenChildForm(new QLDuAnPhanMemTinHoc.form.PhanCongCongViec(this.quyenHan));

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new QLDuAnPhanMemTinHoc.form.TrangChu(this.quyenHan));
        }
    }
}