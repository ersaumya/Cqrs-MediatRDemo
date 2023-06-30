using Cqrs_MediatRDemo.Models;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Command
{
    public record AddProductCommand:IRequest<Product>
    {
        public AddProductCommand(string name,decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
