namespace TT_CSDL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SDT")]
    public partial class SDT
    {
        [Key]
        [StringLength(3)]
        public string MaSDT { get; set; }

        [Column("SDT")]
        [StringLength(15)]
        public string SDT1 { get; set; }

        [StringLength(4)]
        public string MaNV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
