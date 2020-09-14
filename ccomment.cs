namespace ITNews
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("it_news.ccomment")]
    public partial class ccomment
    {
        [Key]
        [Column(TypeName = "uint")]
        public long idComment { get; set; }

        [Required]
        [StringLength(64)]
        public string text { get; set; }

        [Column(TypeName = "uint")]
        public long idUser { get; set; }

        [Column(TypeName = "uint")]
        public long idArticle { get; set; }

        public virtual article article { get; set; }

        public virtual uuser uuser { get; set; }
    }
}
