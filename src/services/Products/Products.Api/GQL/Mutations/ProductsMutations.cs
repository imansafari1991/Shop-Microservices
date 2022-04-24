using GraphQL;
using GraphQL.Types;
using MediatR;
using Products.Api.GQL.Types.Products;
using Products.Application.Products.Commands.Create;
using Products.Application.Products.Commands.Update;
using Products.Domain.Products;

namespace Products.Api.GQL.Mutations
{
    public static class ProductsMutations
    {
        public static void ProductMutations(this ObjectGraphType schema, IMediator mediator)
        {
            schema.FieldAsync<ProductResType>(
                "addProduct",
                "Is used to add a new product to the database",
                arguments:new QueryArguments(new QueryArgument<NonNullGraphType<ProductReqType>> { Name = "productInput", Description = "Product input parameter" }),
                resolve: async context =>
                {
                    var addProduct = context.GetArgument<AddProductCommand>("productInput");
                    ProductResDto addProductRes = new ProductResDto();
                    try
                    {
                        addProductRes = await mediator.Send(addProduct);
                    }
                    catch (Exception ex)
                    {
                        context.Errors.Add(new ExecutionError(ex.Message));
                        return null;
                    }
                  
                    return addProductRes;
                }

            );
            schema.FieldAsync<BooleanGraphType>(
                "updateProduct",
                "Is used to update a  product to the database",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<ProductReqType>> { Name = "productInput", Description = "Product input parameter" }),

                resolve: async context =>
                {
                    UpdateProductCommand updateProduct = context.GetArgument<UpdateProductCommand>("productInput");
                    bool updateProductRes;
                    try
                    {
                        updateProductRes = await mediator.Send(updateProduct);
                    }
                    catch (Exception ex)
                    {

                        context.Errors.Add(new ExecutionError(ex.Message));
                        return null;

                    }

                    return updateProductRes;
                });
        }
    }
}
