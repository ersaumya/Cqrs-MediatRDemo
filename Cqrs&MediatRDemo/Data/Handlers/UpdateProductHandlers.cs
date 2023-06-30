using Cqrs_MediatRDemo.Data.Command;
using Cqrs_MediatRDemo.Models;
using Cqrs_MediatRDemo.Services;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Handlers
{
    public class UpdateProductHandlers : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        public UpdateProductHandlers(IProductRepository productRepository) => _productRepository = productRepository;

        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductListByIdAsync(request.Id);
            if (product == null)
            {
                return default;
            }
            product.Name = request.Name;
            product.Price = request.Price;
            return await _productRepository.UpdateProductAsync(product);
        }
    }
}
