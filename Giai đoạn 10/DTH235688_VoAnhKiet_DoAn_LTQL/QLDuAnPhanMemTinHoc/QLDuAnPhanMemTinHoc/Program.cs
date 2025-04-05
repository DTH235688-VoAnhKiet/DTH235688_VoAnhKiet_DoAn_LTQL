using QLDuAnPhanMemTinHoc.form;

namespace QLDuAnPhanMemTinHoc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Bộ SIÊU DỮ LIỆU "FULL OPTION" đã được nạp thành công
            Data.DatabaseSeeder.Seed();

            // Patch lỗi / Duy trì Schema
            Data.DatabaseSeeder.FixOldData();
            
            Application.Run(new form.DangNhap());


        }
    }
}