using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discount.Domain.Enums;
using Discount.Domain.Base;

namespace Discount.Domain.Coupons
{
    public class Coupon:BaseEntity
    {
        [Required]
        public int ProductId { get; set; }
        [MaxLength(300)]
        public string ProductName { get; set; }
        public DiscountType DiscountType { get; set; }
        public int Value { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
