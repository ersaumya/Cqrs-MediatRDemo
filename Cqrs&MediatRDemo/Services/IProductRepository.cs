using Cqrs_MediatRDemo.Models;

namespace Cqrs_MediatRDemo.Services
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProductListAsync();
        public Task<Product> GetProductListByIdAsync(int Id);
        public Task<Product> AddProductAsync(Product product);
        public Task<int> UpdateProductAsync(Product product);
        public Task<int> DeleteProductAsync(int Id);
    }
}
