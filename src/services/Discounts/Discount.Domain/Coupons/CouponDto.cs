using Discount.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount.Domain.Coupons
{
    public class CouponDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public DiscountType DiscountType { get; set; }
        public int Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
