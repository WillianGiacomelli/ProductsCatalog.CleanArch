using Application.Interfaces;
using Application.Products.Commands;
using Domain.Entities;
using MediatR;

namespace Application.Products.Handlers;

public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Product>
{
    private readonly IProductService _productService;
    public ProductCreateCommandHandler(IProductService _service)
    {
        _productService = _service;
    }
    public async Task<Product> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
    {
        var product = _productService.GetProductById(request.Id);
        if (product is null) { 
           
        }
    }
}
