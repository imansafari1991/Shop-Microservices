
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Discount.Domain.Coupons;
using Microsoft.EntityFrameworkCore;

namespace Discount.Infrastructure
{
    public class DiscountDbContext : DbContext
    {
        public DiscountDbContext(DbContextOptions<DiscountDbContext> options) : base(options)
        {
        }
      
        public DbSet<Coupon> Coupons { get; set; }
    }
}
