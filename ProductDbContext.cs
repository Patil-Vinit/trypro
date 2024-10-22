using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Product_Show.Models;

public partial class ProductDbContext : DbContext
{
    public ProductDbContext()
    {
    }

    public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductDetail> ProductDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductDetail>(entity =>
        {
            entity.HasKey(e => e.ProSn).HasName("PK__Product___04BABCE7382A2269");

            entity.ToTable("Product_Details");

            entity.Property(e => e.ProSn).HasColumnName("Pro_Sn");
            entity.Property(e => e.ProName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Pro_Name");
            entity.Property(e => e.ProPrice).HasColumnName("Pro_Price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
