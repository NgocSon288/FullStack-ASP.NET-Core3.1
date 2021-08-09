using cShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace cShop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.Description)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.Content)
                .IsRequired(true);

            builder.Property(p => p.Price)
                .IsRequired(true);

            builder.Property(p => p.Promotion)
                .IsRequired(true);

            builder.Property(p => p.DateCreated)
                .HasDefaultValue(DateTime.Now);

            builder.Property(p => p.IsFreeship)
                .HasDefaultValue(false);

            builder.Property(p => p.IsInstallment)
                .HasDefaultValue(false);

            builder.Property(p => p.ViewCount)
                .HasDefaultValue(0);

            builder.Property(p => p.Rating)
                .HasDefaultValue(0);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            builder.HasOne(p => p.Brand)
                .WithMany(b => b.Products)
                .HasForeignKey(p => p.BrandId);
        }
    }
}