namespace TT_CSDL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRUYEN_THELOAI
    {
        public int ID { get; set; }

        [StringLength(15)]
        public string MaSP { get; set; }

        public int? MaTheLoai { get; set; }

        public virtual THELOAI THELOAI { get; set; }

        public virtual TRUYEN TRUYEN { get; set; }
    }
}
