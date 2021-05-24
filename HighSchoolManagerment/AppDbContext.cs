using HighSchoolManagerment.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HighSchoolManagerment.Data.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<NguoiDung> NguoiDung { get; set; }

        public DbSet<Quyen> Quyen { get; set; }

        public DbSet<ChucNang> ChucNang { get; set; }

        public DbSet<VaiTro> VaiTro { get; set; }

        public DbSet<BangDiem> BangDiem { get; set; }

        public DbSet<NhomNguoiDung> NhomNguoiDung { get; set; }

        public DbSet<MonHoc> MonHoc { get; set; }

        public DbSet<Lop> Lop { get; set; }

        public DbSet<TKB> TKB { get; set; }

        public DbSet<NguoiDungLop> NguoiDungLop { get; set; }

        public DbSet<TonGiao> TonGiao { get; set; }

        public DbSet<HanhKiem> HanhKiem { get; set; }

        public DbSet<HocLuc> HocLuc { get; set; }

        public DbSet<NamHoc> NamHoc { get; set; }

        public DbSet<GioiTinh> GioiTinh { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiDungLop>().HasKey(x => new { x.MaND, x.MaLop });
            modelBuilder.Entity<VaiTro>().HasKey(x => new { x.MaVT, x.MaNND });

            //base.OnModelCreating(modelBuilder);
        }
    }
    
}