using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QLDuAnPhanMemTinHoc.Data
{
    public class QLDADbContext : DbContext
    {
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<DuAn> DuAn { get; set; }
        public DbSet<PhanCong> PhanCong { get; set; }
        public DbSet<CongViec> CongViec { get; set; }
        public DbSet<PhanCongCongViec> PhanCongCongViec { get; set; }
        public DbSet<TienDo> TienDo { get; set; }
        public DbSet<Bug> Bug { get; set; }
        public DbSet<VaiTro> VaiTro { get; set; }
        public DbSet<NhanVien_VaiTro> NhanVien_VaiTro { get; set; }
        public DbSet<TaiLieuDuAn> TaiLieuDuAn { get; set; }
        public DbSet<NhatKyHoatDong> NhatKyHoatDong { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings["QLDAConnection"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bug>()
        .HasOne(b => b.NguoiBaoCao)
        .WithMany(nv => nv.BugBaoCao)
        .HasForeignKey(b => b.NguoiBaoCaoID)
        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Bug>()
                .HasOne(b => b.NguoiXuLy)
                .WithMany(nv => nv.BugXuLy)
                .HasForeignKey(b => b.NguoiXuLyID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhanCongCongViec>()
                .HasOne(pc => pc.NhanVien)
                .WithMany(nv => nv.PhanCongCongViec)
                .HasForeignKey(pc => pc.NhanVienID)
                .OnDelete(DeleteBehavior.Restrict); //  QUAN TRỌNG

            modelBuilder.Entity<PhanCongCongViec>()
                .HasOne(pc => pc.CongViec)
                .WithMany(cv => cv.PhanCongCongViec)
                .HasForeignKey(pc => pc.CongViecID)
                .OnDelete(DeleteBehavior.Cascade);

               

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PhanCong>()
        .HasOne(p => p.NhanVien)
        .WithMany(n => n.PhanCongs)
        .HasForeignKey(p => p.NhanVienID)
        .OnDelete(DeleteBehavior.NoAction);

            
         modelBuilder.Entity<PhanCong>()
                .HasOne(p => p.DuAn)
                .WithMany(d => d.PhanCongs)
                .HasForeignKey(p => p.DuAnID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
