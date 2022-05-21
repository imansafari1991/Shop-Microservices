using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Discount.Domain.Coupons;

namespace Discount.Infrastructure.Domain.Coupons
{
    public class CouponMappingProfile:Profile
    {

        public CouponMappingProfile()
        {
            CreateMap<Coupon, CouponDto>().ReverseMap();
        }
    }
}
