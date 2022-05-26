using AutoMapper;
using Discount.Application.Coupons.Create;
using EventBus.Messages.Events;
using MassTransit;
using MediatR;

namespace Discount.Application.EventBusConsumers
{
    public class AddProductConsumer : IConsumer<AddProductEvent>
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public AddProductConsumer(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task Consume(ConsumeContext<AddProductEvent> context)
        {
            CreateCouponCommand createCouponCommand = new CreateCouponCommand
            {
                ProductId = context.Message.ProductId,
                ProductTitle = context.Message.ProductTitle
            };
            var result = await _mediator.Send(createCouponCommand);
        }
    }
}
