using GraphQL;
using GraphQL.Types;
using MediatR;
using Products.Api.GQL.Types.Products;
using Products.Application.Products.Commands.Create;
using Products.Domain.Products;

namespace Products.Api.GQL.Mutations
{
    public static class ProductsMutation
    {
        public static void ProductMutations(this ObjectGraphType schema, IMediator mediator)
        {
            schema.FieldAsync<ProductResType>(
                 "addProduct",
                 "Is used to add a new product to the database",
                 arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductReqType>> { Name = "product", Description = "Product input parameter" }),
               
                 resolve: async context =>
                 {
                     AddProductCommand addProduct = addProduct = context.GetArgument<AddProductCommand>("product");
                     ProductResDto addProductRes = new ProductResDto();
                     try
                     {
                          addProductRes = await mediator.Send(addProduct);
                     }
                     catch (Exception ex)
                     {
                         var type = ex.GetType();
                       context.Errors.Add(new  ExecutionError(ex.Message));
                         return null;

                     }
                 
                     
                     
                     return addProductRes;
                 });
        }
    }
}
