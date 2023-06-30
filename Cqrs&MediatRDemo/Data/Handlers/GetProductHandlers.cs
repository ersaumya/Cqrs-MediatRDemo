using Cqrs_MediatRDemo.Data.Queries;
using Cqrs_MediatRDemo.Models;
using Cqrs_MediatRDemo.Services;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Handlers
{
    public class GetProductHandlers : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository _productRepository;
        public GetProductHandlers(IProductRepository productRepository) => _productRepository = productRepository;
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductListByIdAsync(request.Id);
        }
    }
}
