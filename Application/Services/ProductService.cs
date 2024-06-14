using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
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

    public async Task Add(ProductDTO productDTO)
    {
        var productEntity = _mapper.Map<Product>(productDTO);
        await _repository.CreateAsync(productEntity);
        
    }

    public async Task<ProductDTO> GetProductById(int id)
    {
        var productEntity = await _repository.GetProductByIdAsync(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }

    public async Task<ProductDTO> GetProductCategory(int id)
    {
        var productEntity = await _repository.GetProductCategoryAsync(id);
        return _mapper.Map<ProductDTO>(productEntity);
    }

    public async Task<IEnumerable<ProductDTO>> GetProducts()
    {
        var productsEntity = await _repository.GetProductsAsync();
        return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
    }

    public async Task Remove(int id)
    {
        var productEntity = _repository.GetProductByIdAsync(id).Result;
        if (productEntity is not null)
        {
            await _repository.DeleteAsync(productEntity);
        }
    }

    public async Task Update(ProductDTO productDTO)
    {
        var updateProductEntitie = _mapper.Map<Product>(productDTO);
        await _repository.UpdateAsync(updateProductEntitie);
    }
}
