
using Discount.Domain.Coupons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Discount.Infrastructure.Domain.Coupons
{
    public class CouponRepository : ICouponRepository
    {
        private readonly DiscountDbContext _context;

        public CouponRepository(DiscountDbContext context)
        {
            _context = context;
        }

        public async Task<EntityEntry<Coupon>> AddAsync(Coupon coupon)
        { 
            coupon.CreationDateTime= DateTime.UtcNow;
            coupon.ModificationDateTime = DateTime.UtcNow;

            return await _context.Coupons.AddAsync(coupon);
            
        }

        public async Task Delete(Coupon coupon)
        {
            _context.Coupons.Remove(coupon);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Coupon>> GetAllAsync()
        {
            return await _context.Coupons.ToListAsync();
            
        }

        public async Task<Coupon> GetAsync(int couponId)
        {
            return await _context.Coupons.FindAsync(couponId);
        }

        public void Update(Coupon coupon)
        {
            coupon.ModificationDateTime= DateTime.UtcNow;
            _context.Coupons.Update(coupon);
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
