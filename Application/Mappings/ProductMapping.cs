using Application.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings;

public class CategoryMapping : Profile
{
    public CategoryMapping()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
    }
}
