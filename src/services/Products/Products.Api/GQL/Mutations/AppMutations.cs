using GraphQL.Types;
using MediatR;

namespace Products.Api.GQL.Mutations
{
    public class AppMutations:ObjectGraphType
    {
        public AppMutations(IMediator mediator)
        {
            this.ProductMutations(mediator);
        }
    }
}
