using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Discount.Domain.Coupons;
using MediatR;

namespace Discount.Application.Coupons.Create
{
    public class CreateCouponCommandHandler : IRequestHandler<CreateCouponCommand, int>
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public CreateCouponCommandHandler(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCouponCommand request, CancellationToken cancellationToken)
        {
            var coupon = _mapper.Map<Coupon>(request);
            var addedCoupon = await _couponRepository.AddAsync(coupon);
            await _couponRepository.CommitAsync();
            return addedCoupon.Entity.Id;
        }
    }
}
