using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Discount.Domain.Coupons
{
    public interface ICouponRepository
    {
        Task<EntityEntry<Coupon>> AddAsync(Coupon coupon);
        void Update(Coupon coupon);
        
        Task<Coupon> GetAsync(int couponId);
        Task<IEnumerable<Coupon>> GetAllAsync();
        Task CommitAsync();
        Task Delete(Coupon coupon);
    }
}
