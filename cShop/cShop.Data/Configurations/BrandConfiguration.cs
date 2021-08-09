using cShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace cShop.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.ToTable("Brands");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.Description)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.DateCreated)
                .HasDefaultValue(DateTime.Now);


            builder.HasOne(b => b.Category)
                .WithMany(c => c.Brands)
                .HasForeignKey(b => b.CategoryId);
        }
    }
}