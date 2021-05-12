namespace TT_CSDL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
        }

        [Key]
        [StringLength(15)]
        public string MaSP { get; set; }

        [StringLength(200)]
        public string Ten { get; set; }

        [StringLength(20)]
        public string LoaiSP { get; set; }

        public DateTime? NgayNhap { get; set; }

        [StringLength(10)]
        public string MaGG { get; set; }

        public decimal? GiaGoc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DonGia { get; set; }

        [StringLength(10)]
        public string MaTT { get; set; }

        public short? SoLuong { get; set; }

        [StringLength(100)]
        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        public virtual PHIEUGIAMGIA PHIEUGIAMGIA { get; set; }

        public virtual TRANGTHAI TRANGTHAI { get; set; }

        public virtual SPKHAC SPKHAC { get; set; }

        public virtual TRUYEN TRUYEN { get; set; }
    }
}
