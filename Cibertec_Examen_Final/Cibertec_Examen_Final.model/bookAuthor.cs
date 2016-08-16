namespace Cibertec_Examen_Final.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bookAuthor")]
    public partial class bookAuthor
    {
        public int? au_id { get; set; }

        public int? title_id { get; set; }

        [Key]
        [StringLength(100)]
        public string au_ord { get; set; }

        [StringLength(100)]
        public string royaltyper { get; set; }

        public virtual authors authors { get; set; }

        public virtual books books { get; set; }
    }
}
