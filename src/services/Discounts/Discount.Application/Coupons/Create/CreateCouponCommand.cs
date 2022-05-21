using Discount.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount.Domain.Coupons;

namespace Discount.Application.Coupons.Create
{
    public class CreateCouponCommand: CouponDto,IRequest<int>
    {
 
    }
}
