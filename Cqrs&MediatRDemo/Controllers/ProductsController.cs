using Cqrs_MediatRDemo.Data.Command;
using Cqrs_MediatRDemo.Data.Queries;
using Cqrs_MediatRDemo.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cqrs_MediatRDemo.Controllers
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

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<List<Product>> ProductList()
        {
            var productList = await _mediator.Send(new GetProductListQuery());
            return productList;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<Product> ProductById(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery() { Id=id});
            return product;
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<Product> AddProduct(Product product)
        {
            var productResult = await _mediator.Send(new AddProductCommand(product.Name,product.Price));
            return productResult;
        }

        // PUT api/<ProductsController>/5
        [HttpPut]
        public async Task<int> UpdateProduct(Product product)
        {
            var productResult = await _mediator.Send(new UpdateProductCommand(product.Id,product.Name, product.Price));
            return productResult;
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task<int> DeleteProduct(int id)
        {
            return await _mediator.Send(new DeleteProductCommand() { Id = id });
        }
    }
}
