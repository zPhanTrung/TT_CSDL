namespace TT_CSDL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRUYEN")]
    public partial class TRUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRUYEN()
        {
            TRUYEN_THELOAI = new HashSet<TRUYEN_THELOAI>();
        }

        [Key]
        [StringLength(15)]
        public string MaSP { get; set; }

        [StringLength(20)]
        public string NhaXuatBan { get; set; }

        [StringLength(4)]
        public string NamXB { get; set; }

        [StringLength(50)]
        public string TacGia { get; set; }

        [StringLength(20)]
        public string QuocGia { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRUYEN_THELOAI> TRUYEN_THELOAI { get; set; }
    }
}
