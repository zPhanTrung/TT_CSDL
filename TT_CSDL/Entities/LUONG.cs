namespace TT_CSDL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LUONG")]
    public partial class LUONG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLuong { get; set; }

        public short? SoCong { get; set; }

        [Column(TypeName = "money")]
        public decimal? DonGia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBD { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKT { get; set; }

        [Column(TypeName = "money")]
        public decimal? ThanhTien { get; set; }

        public bool? TrangThai { get; set; }

        [StringLength(4)]
        public string MaNV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
