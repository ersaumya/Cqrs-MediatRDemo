using Cqrs_MediatRDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace Cqrs_MediatRDemo.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
