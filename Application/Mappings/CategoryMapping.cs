
using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class ProductMapping : Profile
{
    public ProductMapping()
    {
        CreateMap<Product, ProductDTO>().ReverseMap();
    }
}
