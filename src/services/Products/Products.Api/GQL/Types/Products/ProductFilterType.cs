using GraphQL.Types;

namespace Products.Api.GQL.Types.Products
{
    public class ProductFilterType: InputObjectGraphType
    {
        public ProductFilterType()
        {

            Name =nameof(ProductFilterType);
            Field<IntGraphType>("Id");
            Field<StringGraphType>("SearchTerm");
            Field<DecimalGraphType>("MinPrice");
            Field<DecimalGraphType>("MaxPrice");
            Field<StringGraphType>("Code");
            Field<StringGraphType>("Permalink");
            Field<IntGraphType>("CategoryId");
            Field<IntGraphType>("PageIndex");
            Field<IntGraphType>("PageSize");

        }


    }
}
