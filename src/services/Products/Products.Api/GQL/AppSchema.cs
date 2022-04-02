using GraphQL.Types;
using Products.Api.GQL.Mutations;
using Products.Api.GQL.Queries;

namespace Products.Api.GQL
{
    public class AppSchema : Schema
    {
        public AppSchema(AppQueries appQueries, AppMutations appMutations)
        {
            this.Query = appQueries;
            this.Mutation = appMutations;
        }
    }
}
