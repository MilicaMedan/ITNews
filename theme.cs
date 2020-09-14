namespace ITNews
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("it_news.theme")]
    public partial class theme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public theme()
        {
            uusers = new HashSet<uuser>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long idTheme { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uuser> uusers { get; set; }
    }
}
