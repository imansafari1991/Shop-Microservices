using AutoMapper;
using Discount.Domain.Coupons;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Discount.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DicountsController : ControllerBase
    {
        private readonly ICouponRepository _couponRepository;
        private readonly IMapper _mapper;

        public DicountsController(ICouponRepository couponRepository, IMapper mapper)
        {
            _couponRepository = couponRepository;
            _mapper = mapper;
        }
        // GET: api/<DicountsController>
        [HttpGet]
        public async Task<IEnumerable<CouponDto>> Get()
        {
            var coupons = await _couponRepository.GetAllAsync();
            return _mapper.Map<List<CouponDto>>(coupons);
        }

       

        // GET api/<DicountsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Coupon>> Get(int id)
        {
            var coupon = await _couponRepository.GetAsync(id);
            if (coupon == null)
            {
                return NotFound();
            }
            return coupon;
        }

        // POST api/<DicountsController>
        [HttpPost]
        public async Task Post([FromBody] CouponDto dto)
        {
            var coupon = _mapper.Map<Coupon>(dto);
            await _couponRepository.AddAsync(coupon);
            await _couponRepository.CommitAsync();

        }

        // PUT api/<DicountsController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] CouponDto dto)
        {
            dto.Id = id;
            var coupon = _mapper.Map<Coupon>(dto);

            _couponRepository.Update(coupon);
            await _couponRepository.CommitAsync();

        }

        // DELETE api/<DicountsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var coupon = await _couponRepository.GetAsync(id);
            if (coupon == null)
            {
                return NotFound();
            }
           await _couponRepository.Delete(coupon);
            await _couponRepository.CommitAsync();
            return Ok();
          
        }
    }
}
