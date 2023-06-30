using Cqrs_MediatRDemo.Models;
using MediatR;

namespace Cqrs_MediatRDemo.Data.Queries
{
    public record GetProductListQuery: IRequest<List<Product>>
    {
    }
}
