using Cqrs_MediatRDemo.Models;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Command
{
    public record UpdateProductCommand:IRequest<int>
    {
        public UpdateProductCommand(int id,string name,decimal price)
        {
            Id = id;
            Name=name;
            Price=price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
