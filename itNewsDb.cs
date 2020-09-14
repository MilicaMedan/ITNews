namespace ITNews
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class itNewsDb : DbContext
    {
        public itNewsDb()
            : base("name=itNewsDb")
        {
        }

        public virtual DbSet<article> articles { get; set; }
        public virtual DbSet<ccomment> ccomments { get; set; }
        public virtual DbSet<llanguage> llanguages { get; set; }
        public virtual DbSet<theme> themes { get; set; }
        public virtual DbSet<uuser> uusers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<article>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<article>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<article>()
                .HasMany(e => e.ccomments)
                .WithRequired(e => e.article)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ccomment>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<llanguage>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<llanguage>()
                .HasMany(e => e.articles)
                .WithRequired(e => e.llanguage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<llanguage>()
                .HasMany(e => e.uusers)
                .WithRequired(e => e.llanguage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<theme>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<theme>()
                .HasMany(e => e.uusers)
                .WithRequired(e => e.theme)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<uuser>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<uuser>()
                .Property(e => e.passwordHash)
                .IsUnicode(false);

            modelBuilder.Entity<uuser>()
                .HasMany(e => e.articles)
                .WithRequired(e => e.uuser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<uuser>()
                .HasMany(e => e.ccomments)
                .WithRequired(e => e.uuser)
                .WillCascadeOnDelete(false);
        }
    }
}
