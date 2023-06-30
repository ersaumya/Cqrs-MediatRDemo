using Cqrs_MediatRDemo.Models;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Command
{
    public record DeleteProductCommand:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
