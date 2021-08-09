using cShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace cShop.Data.Configurations
{
    public class ProductParameterConfiguration : IEntityTypeConfiguration<ProductParameter>
    {
        public void Configure(EntityTypeBuilder<ProductParameter> builder)
        {
            builder.ToTable("ProductParameters");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.Property(p => p.Content)
                .IsRequired(true)
                .HasMaxLength(200);

            builder.HasOne(pp => pp.Product)
                .WithMany(p => p.ProductParameters)
                .HasForeignKey(pp => pp.ProductId);
        }
    }
}