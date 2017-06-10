namespace Library.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelDB : DbContext
    {
        public ModelDB()
            : base("name=ModelDB")
        {

        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BorrowRecord> BorrowRecord { get; set; }
        public virtual DbSet<CancelRecord> CancelRecord { get; set; }
        public virtual DbSet<Catogary> Catogary { get; set; }
        public virtual DbSet<ChargeRecord> ChargeRecord { get; set; }
        public virtual DbSet<FineRecord> FineRecord { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.price)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.BorrowRecord)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.CancelRecord)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.FineRecord)
                .WithRequired(e => e.Book)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Catogary>()
                .Property(e => e.serialNumber)
                .IsUnicode(false);

            modelBuilder.Entity<ChargeRecord>()
                .Property(e => e.money)
                .HasPrecision(10, 4);

            modelBuilder.Entity<FineRecord>()
                .Property(e => e.fine)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Reader>()
                .Property(e => e.deposit)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Reader>()
                .Property(e => e.idCard)
                .IsFixedLength();

            modelBuilder.Entity<Reader>()
                .HasMany(e => e.BorrowRecord)
                .WithRequired(e => e.Reader)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reader>()
                .HasOptional(e => e.ChargeRecord)
                .WithRequired(e => e.Reader);

            modelBuilder.Entity<Reader>()
                .HasOptional(e => e.FineRecord)
                .WithRequired(e => e.Reader);
        }
    }
}
