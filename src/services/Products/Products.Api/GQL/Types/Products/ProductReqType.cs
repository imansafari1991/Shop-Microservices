using GraphQL.Types;
using Products.Domain.Products;

namespace Products.Api.GQL.Types.Products
{
    public class ProductReqType : InputObjectGraphType
    {
        public ProductReqType()
        {
            Name = "ProductReqType";
            Field<IntGraphType>("Id");
            Field<BooleanGraphType>("Active");
            Field<StringGraphType>("Title");
            Field<StringGraphType>("Description");
            
            Field<StringGraphType>("CoverImageUrl");
            Field<DecimalGraphType>("Price");

            Field<StringGraphType>("Code");
            Field<StringGraphType>("Permalink");
            Field<IdGraphType>("CategoryId");

        }
    }
}
