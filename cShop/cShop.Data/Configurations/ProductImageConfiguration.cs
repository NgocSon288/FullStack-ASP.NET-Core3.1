using cShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace cShop.Data.Configurations
{
    public class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("ProductImages");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.ImagePath)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.Alt)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.Description)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.DisplayOrder)
                .IsRequired(true);

            builder.Property(p => p.DateCreated)
                .HasDefaultValue(DateTime.Now);


            builder.HasOne(pi => pi.Product)
                .WithMany(p => p.ProductImages)
                .HasForeignKey(pi => pi.ProductId);
        }
    }
}