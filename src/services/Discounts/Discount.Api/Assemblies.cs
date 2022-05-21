using Discount.Application.Coupons.Create;
using Discount.Domain.Coupons;

using System.Reflection;
using Discount.Infrastructure;

namespace Products.Api
{
    public static class Assemblies
    {
        public static readonly Assembly EntityAssembly = typeof(Coupon).Assembly;
        public static readonly Assembly ApplicationAssembly = typeof(CreateCouponCommand).Assembly;
        public static readonly Assembly InfrastructureAssembly = typeof(DiscountDbContext).Assembly;
    }
}
