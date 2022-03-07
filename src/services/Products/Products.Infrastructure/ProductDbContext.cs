using Microsoft.EntityFrameworkCore;
using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Domain.Categories;

namespace Products.Infrastructure
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Order is important. Because first we have insert into Category and then use categoryId when inserting Product
            modelBuilder.ApplyConfiguration(new Category.CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new Product.ProductConfiguration());
        }
    }
}
