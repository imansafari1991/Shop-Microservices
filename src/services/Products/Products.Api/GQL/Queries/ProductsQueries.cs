using GraphQL.Types;
using MediatR;
using Products.Api.GQL.Types.Products;
using Products.Application.Products.Queries.GetProductsList;

namespace Products.Api.GQL.Queries
{
    public static class ProductsQueries
    {

        public static void ProductQueries(this ObjectGraphType schema, IMediator mediator)
        {
            schema.Field<ListGraphType<ProductResType>>(
              "getProducts",
              description: "return list of prdoucts",
              resolve: context => mediator.Send(new GetProductsListQuery())

          );
        }
    }
}
