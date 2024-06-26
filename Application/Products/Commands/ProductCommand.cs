﻿using Domain.Entities;
using MediatR;

namespace Application.Products.Commands;

public abstract class ProductCommand : IRequest<Product>
{
    public int Id { get; set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string? Image { get; private set; }
    public int CategoryId { get; set; }
}