using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Products.Domain.Products;

namespace Products.Infrastructure.Products
{
    public class ProductReadRepository : IProductReadRepository
    {
        private readonly ProductDbContext _dbContext;
        public ProductReadRepository(ProductDbContext dbContext)
        {
                _dbContext=dbContext;
        }
        public async Task<List<Product>> GetAllAsync()
        {
            return await _dbContext.Products.Include(p=>p.Category).ToListAsync();
        }

        public async Task<Product> GetAsync(int id)
        {
              return await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<Product> GetAsyncNoTracking(int id)
        {
            return await _dbContext.Products.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
