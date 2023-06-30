using Cqrs_MediatRDemo.Models;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Queries
{
    public record GetProductByIdQuery:IRequest<Product>
    {
        public int Id { get; set; }
    }
}
