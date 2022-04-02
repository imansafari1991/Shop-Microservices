using GraphQL.Types;
using MediatR;

namespace Products.Api.GQL.Queries
{
    public class AppQueries : ObjectGraphType
    {
        public AppQueries(IMediator mediator)
        {

            this.ProductQueries(mediator);
         


        }
    }
}
