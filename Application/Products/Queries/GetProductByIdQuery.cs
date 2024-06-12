using Domain.Entities;
using MediatR;

namespace Application.Products.Queries;

public class GetProductByIdQuery : IRequest<Product>
{
    public int Id { get; set; }
    public int ProductId { get; set; }

    public GetProductByIdQuery(int id)
    {
        Id = id;
    }
}
