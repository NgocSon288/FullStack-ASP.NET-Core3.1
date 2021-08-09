﻿using cShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace cShop.Data.Configurations
{
    public class BrandImageConfiguration : IEntityTypeConfiguration<BrandImage>
    {
        public void Configure(EntityTypeBuilder<BrandImage> builder)
        {
            builder.ToTable("BrandImages");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.ImagePath)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.Alt)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.DateCreated)
                .HasDefaultValue(DateTime.Now);


            builder.HasOne(bi => bi.Brand)
                .WithOne(b => b.BrandImage)
                .HasForeignKey<BrandImage>(bi=>bi.BrandId);
        }
    }
}