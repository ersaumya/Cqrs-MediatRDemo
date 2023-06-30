using Cqrs_MediatRDemo.Data;
using Cqrs_MediatRDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace Cqrs_MediatRDemo.Services
{
    public class ProductRepository : IProductRepository
    {
        public readonly DataContext _dbContext;
        public ProductRepository(DataContext dbcontext) => _dbContext = dbcontext;
        
        public async Task<Product> AddProductAsync(Product product)
        {
            var result=_dbContext.Products.Add(product);
            await _dbContext.SaveChangesAsync();
            return result.Entity;

        }

        public async Task<int> DeleteProductAsync(int Id)
        {
            var fetchData = _dbContext.Products.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.Products.Remove(fetchData);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetProductListAsync()
        {
            var fetchData = await _dbContext.Products.ToListAsync();
            return fetchData;
        }

        public async Task<Product> GetProductListByIdAsync(int Id)
        {
            var fetchData = await _dbContext.Products.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return fetchData;
        }

        public async Task<int> UpdateProductAsync(Product product)
        {
            _dbContext.Products.Update(product);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
