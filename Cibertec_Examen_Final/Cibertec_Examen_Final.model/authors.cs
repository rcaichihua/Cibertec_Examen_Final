namespace Cibertec_Examen_Final.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class authors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public authors()
        {
            bookAuthor = new HashSet<bookAuthor>();
        }

        [Key]
        public int au_id { get; set; }

        [Required]
        [StringLength(100)]
        public string au_lname { get; set; }

        [Required]
        [StringLength(100)]
        public string au_fname { get; set; }

        [Required]
        [StringLength(100)]
        public string au_phone { get; set; }

        [Required]
        [StringLength(100)]
        public string au_city { get; set; }

        [Required]
        [StringLength(100)]
        public string au_state { get; set; }

        [StringLength(50)]
        public string au_zip { get; set; }

        [StringLength(20)]
        public string au_sex { get; set; }

        public decimal? au_salary { get; set; }

        [StringLength(100)]
        public string au_subject { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bookAuthor> bookAuthor { get; set; }
    }
}
