using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TT_CSDL.Entities
{
    public partial class Shop : DbContext
    {
        public Shop()
            : base("name=Shop")
        {
        }

        public virtual DbSet<ChiTietHD> ChiTietHDs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<LUONG> LUONGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUGIAMGIA> PHIEUGIAMGIAs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<SDT> SDTs { get; set; }
        public virtual DbSet<SPKHAC> SPKHACs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<TRANGTHAI> TRANGTHAIs { get; set; }
        public virtual DbSet<TRUYEN> TRUYENs { get; set; }
        public virtual DbSet<TRUYEN_THELOAI> TRUYEN_THELOAI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHD>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHD>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietHD>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ChiTietHD>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaGG)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaTT)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TienPhaiTra)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LUONG>()
                .Property(e => e.DonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LUONG>()
                .Property(e => e.ThanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LUONG>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.TenDN)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGIAMGIA>()
                .Property(e => e.MaGG)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUGIAMGIA>()
                .Property(e => e.PhanTram)
                .HasPrecision(3, 0);

            modelBuilder.Entity<PHIEUGIAMGIA>()
                .Property(e => e.SoTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaGG)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GiaGoc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaTT)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .HasOptional(e => e.SPKHAC)
                .WithRequired(e => e.SANPHAM);

            modelBuilder.Entity<SANPHAM>()
                .HasOptional(e => e.TRUYEN)
                .WithRequired(e => e.SANPHAM);

            modelBuilder.Entity<SDT>()
                .Property(e => e.MaSDT)
                .IsUnicode(false);

            modelBuilder.Entity<SDT>()
                .Property(e => e.SDT1)
                .IsUnicode(false);

            modelBuilder.Entity<SDT>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<SPKHAC>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TenDN)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TRANGTHAI>()
                .Property(e => e.MaTT)
                .IsUnicode(false);

            modelBuilder.Entity<TRUYEN>()
                .Property(e => e.MaSP)
                .IsUnicode(false);

            modelBuilder.Entity<TRUYEN>()
                .Property(e => e.NamXB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TRUYEN_THELOAI>()
                .Property(e => e.MaSP)
                .IsUnicode(false);
        }
    }
}
