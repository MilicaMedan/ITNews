namespace ITNews
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("it_news.article")]
    public partial class article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public article()
        {
            ccomments = new HashSet<ccomment>();
        }

        [Key]
        [Column(TypeName = "uint")]
        public long idArticle { get; set; }

        [Required]
        [StringLength(64)]
        public string title { get; set; }

        [Column(TypeName = "blob")]
        public byte[] picture { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string text { get; set; }

        public bool isTranslated { get; set; }

        [Column(TypeName = "uint")]
        public long idLanguage { get; set; }

        [Column(TypeName = "uint")]
        public long idUser { get; set; }

        public virtual llanguage llanguage { get; set; }

        public virtual uuser uuser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ccomment> ccomments { get; set; }
    }
}
