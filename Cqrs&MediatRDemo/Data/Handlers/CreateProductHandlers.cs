using Cqrs_MediatRDemo.Data.Command;
using Cqrs_MediatRDemo.Models;
using Cqrs_MediatRDemo.Services;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Handlers
{
    public class CreateProductHandlers : IRequestHandler<AddProductCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductHandlers(IProductRepository productRepository) => _productRepository = productRepository;
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };
            return await _productRepository.AddProductAsync(product);
        }
    }
}
