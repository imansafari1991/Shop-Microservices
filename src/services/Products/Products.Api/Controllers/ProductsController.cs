using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Products.Application.Products.Commands.Create;
using Products.Application.Products.Commands.Delete;
using Products.Application.Products.Commands.Update;
using Products.Application.Products.Queries.GetProductsList;
using Products.Domain;
using Products.Domain.Products;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Products.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
   
        //[HttpGet]
        //public async Task<List<ProductResDto>> Get()
        //{
        //    return await _mediator.Send(new GetProductsListQuery());
        //}

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ProductResDto> Post(AddProductCommand request)
        {
        return  await  _mediator.Send(request);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<bool>> Put(int id, UpdateProductCommand request)
        {
            if (id != request.Id)
            {

                return BadRequest("Id in body and query must be equal");
            }
            var res = await _mediator.Send(request);
            return res;

        }

        // DELETE api/<ProductsController>/5
        [HttpDelete]
        public async Task<bool> Delete(DeleteProductCommand request)
        {
            var res = await _mediator.Send(request);
            return res;
        }
    }
}
