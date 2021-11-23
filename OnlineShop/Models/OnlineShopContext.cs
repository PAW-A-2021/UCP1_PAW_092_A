using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OnlineShop.Models
{
    public partial class OnlineShopContext : DbContext
    {
        public OnlineShopContext()
        {
        }

        public OnlineShopContext(DbContextOptions<OnlineShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Produk> Produk { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.Property(e => e.IdCustomer)
                    .HasColumnName("ID_Customer")
                    .ValueGeneratedNever();

                entity.Property(e => e.Alamat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kota)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telepon)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.HasKey(e => e.IdKategori);

                entity.Property(e => e.IdKategori)
                    .HasColumnName("ID_Kategori")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder);

                entity.Property(e => e.IdOrder)
                    .HasColumnName("ID_Order")
                    .ValueGeneratedNever();

                entity.Property(e => e.Jumlah).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TanggalPembelian).HasColumnName("Tanggal_Pembelian");
            });

            modelBuilder.Entity<Produk>(entity =>
            {
                entity.HasKey(e => e.IdProduk);

                entity.Property(e => e.IdProduk)
                    .HasColumnName("ID_Produk")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deskripsi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Harga).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nama)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
