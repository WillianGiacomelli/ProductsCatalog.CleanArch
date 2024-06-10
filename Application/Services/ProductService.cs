using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;

namespace Application.Services;

public class ProductService : IProductService
{
    private IProductRepository _repository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public Task Add(ProductDTO productDTO)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDTO> GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ProductDTO> GetProductCategory(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductDTO>> GetProducts()
    {
        throw new NotImplementedException();
    }

    public Task Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Task Update(ProductDTO productDTO)
    {
        throw new NotImplementedException();
    }
}
