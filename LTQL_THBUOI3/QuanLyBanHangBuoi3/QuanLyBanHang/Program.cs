using QuanLyBanHang.Forms; // Thêm dòng này vào đầu tiên

namespace QuanLyBanHang
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Đảm bảo tên class là frmLoaiSanPham
            // Application.Run(new frmLoaiSanPham());
            Application.Run(new frmSanPham());
        }
    }
}