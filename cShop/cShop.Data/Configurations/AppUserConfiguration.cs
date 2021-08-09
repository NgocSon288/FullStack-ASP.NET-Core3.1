using cShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace cShop.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");

            builder.Property(p => p.FirstName)
                .IsRequired(true)
                .HasMaxLength(20);

            builder.Property(p => p.LastName)
               .IsRequired(true)
               .HasMaxLength(20);

            builder.Property(p => p.Age)
                 .IsRequired(true);

            builder.Property(p => p.Address)
               .IsRequired(true);

            builder.Property(p => p.BirthDay)
               .HasDefaultValue(new DateTime(2000, 07, 29));
        }
    }
}