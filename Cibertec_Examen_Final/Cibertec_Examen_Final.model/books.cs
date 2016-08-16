namespace Cibertec_Examen_Final.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public books()
        {
            bookAuthor = new HashSet<bookAuthor>();
        }

        [Key]
        public int title_id { get; set; }

        [Required]
        [StringLength(200)]
        public string title { get; set; }

        [Required]
        [StringLength(100)]
        public string type { get; set; }

        public int pub_id { get; set; }

        public decimal price { get; set; }

        [StringLength(100)]
        public string advance { get; set; }

        [StringLength(50)]
        public string royalty { get; set; }

        [StringLength(100)]
        public string ytd_sales { get; set; }

        [StringLength(100)]
        public string notes { get; set; }

        public DateTime? pubdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bookAuthor> bookAuthor { get; set; }
    }
}
