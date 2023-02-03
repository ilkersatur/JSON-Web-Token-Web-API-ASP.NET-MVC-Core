using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategori> Kategoris { get; set; } = null!;
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; } = null!;
        public virtual DbSet<Urun> Uruns { get; set; } = null!;
        public virtual DbSet<Kullanici> Kullanicilar { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=SUNUM1\\MSSQLSERVER2014; Initial Catalog =ProductDB; User ID = sa; Password = 1230");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici { KullaniciID = 1, KullaniciAdi = "ilker", Sifre = "1230" },
                new Kullanici { KullaniciID = 2, KullaniciAdi = "sema", Sifre = "1230" });
            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.Property(e => e.KategoriId).HasColumnName("KategoriID");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.ProductVersion).HasMaxLength(32);
            });

            modelBuilder.Entity<Urun>(entity =>
            {
                entity.HasIndex(e => e.KategoriId, "IX_KategoriID");

                entity.Property(e => e.UrunId).HasColumnName("UrunID");

                entity.Property(e => e.Fiyat).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KategoriId).HasColumnName("KategoriID");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Uruns)
                    .HasForeignKey(d => d.KategoriId)
                    .HasConstraintName("FK_dbo.Uruns_dbo.Kategoris_KategoriID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
