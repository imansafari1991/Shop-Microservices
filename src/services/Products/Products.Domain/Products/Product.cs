using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using Products.Domain.Base;
using Products.Domain.Categories;

namespace Products.Domain.Products
{
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string Permalink { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }

        
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public class ProductConfiguration : IEntityTypeConfiguration<Product>
        {
            public void Configure(EntityTypeBuilder<Product> builder)
            {
                builder.HasKey(b => b.Id);
                builder.Property(p => p.Title).IsRequired().HasMaxLength(200);
                builder.Property(p => p.Description).IsRequired().HasMaxLength(5000);
                builder.Property(p => p.Permalink).IsRequired().HasMaxLength(100);
                builder.Property(p => p.CoverImageUrl).IsRequired().HasMaxLength(50)
                    .HasDefaultValue("https://via.placeholder.com/150x150.png");
                builder.Property(p => p.Code).IsRequired().HasMaxLength(50);
                builder.Property(p => p.CreationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.Property(p => p.ModificationDateTime).IsRequired().HasDefaultValue(DateTime.UtcNow);
                builder.HasData(SeedLargeData());
              


            }
            internal List<Product> SeedLargeData()
            {
                var products = new List<Product>();
                using (StreamReader r = new StreamReader(@"SeedData/ProductSeed.json"))
                {
                    string json = r.ReadToEnd();
                    products = JsonConvert.DeserializeObject<List<Product>>(json);
                }
                return products;
            }
        }


    }
}
