namespace TT_CSDL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            ChiTietHDs = new HashSet<ChiTietHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(4)]
        public string MaNV { get; set; }

        [StringLength(10)]
        public string MaGG { get; set; }

        [StringLength(10)]
        public string MaTT { get; set; }

        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        [Column(TypeName = "money")]
        public decimal? TienPhaiTra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHD> ChiTietHDs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual PHIEUGIAMGIA PHIEUGIAMGIA { get; set; }

        public virtual TRANGTHAI TRANGTHAI { get; set; }
    }
}
