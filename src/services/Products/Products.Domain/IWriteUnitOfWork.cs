using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain
{
    public interface IWriteUnitOfWork
    {
        IProductWriteRepository ProductWriteRepository { get; }
    }
}
