using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BikesWebApplication
{
    public partial class DBLytvynenkoContext : DbContext
    {
        public DBLytvynenkoContext()
        {
        }

        public DBLytvynenkoContext(DbContextOptions<DBLytvynenkoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bike> Bikes { get; set; } = null!;
        public virtual DbSet<BikesInColor> BikesInColors { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Color> Colors { get; set; } = null!;
        public virtual DbSet<Factory> Factories { get; set; } = null!;
        public virtual DbSet<Shop> Shops { get; set; } = null!;
        public virtual DbSet<Size> Sizes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server= DESKTOP-6GTCNMJ; Database=DBLytvynenko; Trusted_Connection=True; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bike>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.Bikes)
                    .HasForeignKey(d => d.FactoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factories_Bikes");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Bikes)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sizes_Bikes");
            });

            modelBuilder.Entity<BikesInColor>(entity =>
            {
                entity.Property(e => e.Amount)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.Bikes)
                    .WithMany(p => p.BikesInColors)
                    .HasForeignKey(d => d.BikesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bikes_BikesInColors");

                entity.HasOne(d => d.Colors)
                    .WithMany(p => p.BikesInColors)
                    .HasForeignKey(d => d.ColorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Colors_BikesInColors");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Country)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Population)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Factory>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Factories)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Factories_Cities");
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.BikesInColors)
                    .WithMany(p => p.Shops)
                    .HasForeignKey(d => d.BikesInColorsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BikesInColors_Shops");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Shops)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cities_Shops");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
