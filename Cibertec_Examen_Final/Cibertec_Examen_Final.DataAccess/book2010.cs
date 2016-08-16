namespace Cibertec_Examen_Final.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using model;

    public partial class book2010 : DbContext
    {
        public book2010()
            : base("name=book2010")
        {
        }

        public virtual DbSet<authors> authors { get; set; }
        public virtual DbSet<books> books { get; set; }
        public virtual DbSet<bookAuthor> bookAuthor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<authors>()
                .Property(e => e.au_lname)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_fname)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_phone)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_city)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_state)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_zip)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_sex)
                .IsUnicode(false);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_salary)
                .HasPrecision(10, 2);

            modelBuilder.Entity<authors>()
                .Property(e => e.au_subject)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.title)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<books>()
                .Property(e => e.advance)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.royalty)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.ytd_sales)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<bookAuthor>()
                .Property(e => e.au_ord)
                .IsUnicode(false);

            modelBuilder.Entity<bookAuthor>()
                .Property(e => e.royaltyper)
                .IsUnicode(false);
        }
    }
}
