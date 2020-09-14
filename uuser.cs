namespace ITNews
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("it_news.uuser")]
    public partial class uuser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uuser()
        {
            articles = new HashSet<article>();
            ccomments = new HashSet<ccomment>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long idUser { get; set; }

        [Required]
        [StringLength(64)]
        public string userName { get; set; }

        [Required]
        [StringLength(64)]
        public string passwordHash { get; set; }

        public bool isAdmin { get; set; }

        [Column(TypeName = "uint")]
        public long idTheme { get; set; }

        [Column(TypeName = "uint")]
        public long idLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<article> articles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ccomment> ccomments { get; set; }

        public virtual llanguage llanguage { get; set; }

        public virtual theme theme { get; set; }
    }
}
