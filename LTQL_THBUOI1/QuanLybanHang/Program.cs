using QuanLybanHang.Forms;



namespace QuanLybanHang
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmHangSanXuat());
            Application.Run(new frmLoaiSanPham());
        }
    }
}