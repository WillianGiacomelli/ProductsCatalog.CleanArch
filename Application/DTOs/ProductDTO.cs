using Domain.Entities;

namespace Application.DTOs;

public record ProductDTO(
        string Name,
        string Description,
        decimal Price,
        int Stock,
        string? Image,  
        int CategoryId,     
        Category Category
);
