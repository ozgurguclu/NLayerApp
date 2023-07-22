using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Seeds
{
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(new ProductFeature
            {
                Id = 1,
                ProductId = 1,
                Color = "Kırmızı",
                Height = 100,
                Width = 200,
            },
            new ProductFeature
            {
                Id = 2,
                ProductId = 2,
                Color = "Mavi",
                Height = 200,
                Width = 300,
            });
        }
    }
}
