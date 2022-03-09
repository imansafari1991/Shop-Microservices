using Products.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Products
{
    public class ProductResDto : ProductDto
    {
        public int CategoryId { get; set; }
        public string CategoryTitle_Id { get; set; }
        public string CategoryTitle { get; set; }

    }
    public class ProductReqDto : ProductDto
    {

        public int CategoryId { get; set; }

    }

    public class ProductDto : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string Permalink { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Code { get; set; }
    }
}
