using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLybanHang.Data
{
    public class QLBHDbContext : DbContext
    {
        public DbSet<Loaisanpham> LoaiSanPham { get; set; }
        public DbSet<Hangsanxuat> HangSanXuat { get; set; }
        public DbSet<sanpham> SanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<Khachhang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<Hoadonchitiet> HoaDon_ChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBHConnection"].ConnectionString);
        }
    }
}
