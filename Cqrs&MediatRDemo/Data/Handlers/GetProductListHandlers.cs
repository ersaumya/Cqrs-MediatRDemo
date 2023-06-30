using Cqrs_MediatRDemo.Data.Queries;
using Cqrs_MediatRDemo.Models;
using Cqrs_MediatRDemo.Services;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Handlers
{
    public class GetProductListHandlers : IRequestHandler<GetProductListQuery, List<Product>>
    {
        private readonly IProductRepository _productRepository;
        public GetProductListHandlers(IProductRepository productRepository)=> _productRepository = productRepository; 
       

        public async Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductListAsync();
        }
    }
}
