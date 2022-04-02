using GraphQL.Types;
using Products.Domain.Products;

namespace Products.Api.GQL.Types.Products
{
    public class ProductResType : ObjectGraphType<ProductResDto>
    {
        public ProductResType()
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field(x => x.Title, type: typeof(StringGraphType));
            Field(x => x.Permalink, type: typeof(StringGraphType));

            Field(x => x.Price, type: typeof(DecimalGraphType));

            Field(x => x.CoverImageUrl, type: typeof(StringGraphType));

            Field(x => x.Code, type: typeof(StringGraphType));

            Field(x => x.Active, type: typeof(BooleanGraphType));

            Field(x => x.Description, type: typeof(StringGraphType));

            Field(x => x.CategoryTitle, type: typeof(StringGraphType));

            Field(x => x.CategoryId, type: typeof(IntGraphType));

        }
    }
}
