using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Products.Domain.Base;
using Products.Domain.Products;

namespace Products.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQuery: ProductFilterPageReqDto, IRequest<PaginitionResDto<List<ProductResDto>>>
    {
     
    }
}
