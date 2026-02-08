using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyBanHang.Data
{
    public class QLBHDbContext : DbContext
    {
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Dán trực tiếp chuỗi kết nối của bạn vào đây
                optionsBuilder.UseSqlServer(
                    @"Server=LAPTOP-MIPBTPHJ\SQLEXPRESS;Database=QLBH1;Integrated Security=True;TrustServerCertificate=True",
                    providerOptions => providerOptions.EnableRetryOnFailure() // Sửa lỗi Transient failure
                );
            }
        }
    }
}
