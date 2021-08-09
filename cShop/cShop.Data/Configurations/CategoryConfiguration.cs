using cShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace cShop.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.DateCreated)
                .HasDefaultValue(DateTime.Now);

            builder.Property(p => p.Description)
                .IsRequired(true)
                .HasMaxLength(200);
        }
    }
}