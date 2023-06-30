using Cqrs_MediatRDemo.Data.Command;
using Cqrs_MediatRDemo.Services;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Handlers
{
    public class RemoveProductHandlers : IRequestHandler<DeleteProductCommand, int>
    {
        private readonly IProductRepository _productRepository;
        public RemoveProductHandlers(IProductRepository productRepository) => _productRepository = productRepository;

        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.GetProductListByIdAsync(request.Id);
            if (result == null)
            {
                return default;
            }
            return await _productRepository.DeleteProductAsync(request.Id);
        }
    }
}
