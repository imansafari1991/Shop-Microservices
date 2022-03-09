using MediatR;
using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Application.Products.Commands.Delete
{
    public class DeleteProductCommand:IRequest<bool>
    {
        public int Id { get; set; }
    }
}
