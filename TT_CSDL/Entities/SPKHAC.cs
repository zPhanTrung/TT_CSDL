namespace TT_CSDL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SPKHAC")]
    public partial class SPKHAC
    {
        [Key]
        [StringLength(15)]
        public string MaSP { get; set; }

        [StringLength(20)]
        public string XuatXu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySX { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HanSD { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
