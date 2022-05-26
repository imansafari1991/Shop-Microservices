using MediatR;
using Products.Domain;
using Products.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using AutoMapper;
using MassTransit;
using EventBus.Messages.Events;

namespace Products.Application.Products.Commands.Create
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductResDto>
    {
        private readonly IWriteUnitOfWork _writeUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<AddProductCommandHandler> _logger;
        private readonly IPublishEndpoint _publishEndPoint;

        public AddProductCommandHandler(IWriteUnitOfWork writeUnitOfWork, IMapper mapper,IPublishEndpoint publishEndpoint, ILogger<AddProductCommandHandler> logger)
        {
            _writeUnitOfWork = writeUnitOfWork;
            _mapper = mapper;
            _logger = logger;
            _publishEndPoint = publishEndpoint;
        }
        public async Task<ProductResDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var newProduct = _mapper.Map<Domain.Products.Product>(request);
            var addedProduct = await _writeUnitOfWork.ProductWriteRepository.AddAsync(newProduct);
            _logger.LogInformation($"Product {addedProduct.Id} is successfully created.");


            var addProductEvent = new AddProductEvent
            {
                ProductId = addedProduct.Id,
                ProductTitle = addedProduct.Title
            };
            await _publishEndPoint.Publish(addProductEvent);
            return _mapper.Map<ProductResDto>(addedProduct);
        }
    }
}
