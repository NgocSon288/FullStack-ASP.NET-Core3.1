using cShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace cShop.Data.Configurations
{
    public class CategoryImageConfiguration : IEntityTypeConfiguration<CategoryImage>
    {
        public void Configure(EntityTypeBuilder<CategoryImage> builder)
        {
            builder.ToTable("CategoryImages");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.ImagePath)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.Alt)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.DateCreated)
                .HasDefaultValue(DateTime.Now);


            builder.HasOne(ci => ci.Category)
                .WithOne(c => c.CategoryImage)
                .HasForeignKey<CategoryImage>(ci=>ci.CategoryId);
        }
    }
}