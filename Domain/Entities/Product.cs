using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public sealed class Product : BaseEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string? Image { get; private set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public Product(int id ,string name, string description, decimal price, int stock, string? image) : base(id)
    {
        ValidateProductDomain(id, name, description, price, stock, image!);
    }

    public void Update(int productId, string name, string description, decimal price, int stock, string? image, int categoryId)
    {
        ValidateProductDomain(productId, name, description, price, stock, image!);
        CategoryId = categoryId;
    }

    public void ValidateProductDomain(int productId, string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(productId <= 0, "Invalid id -  Id needs to bem greather than 0");
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name -  Name is required");
        DomainExceptionValidation.When(name.Length <= 3, "Invalid name -  Name needs to be greater than 4 characters");
        DomainExceptionValidation.When(name.Length >= 255, "Invalid name -  Name needs to be shorter than 255 characters");
        DomainExceptionValidation.When(description.Length <= 5, "Invalid description -  Description needs to be greater than 5 characters");
        DomainExceptionValidation.When(price <= 0, "Invalid price -  Price needs to be greather than 0");
        DomainExceptionValidation.When(stock < 0, "Invalid stock -  Price cannot be negative");
        DomainExceptionValidation.When(image != "" && image.Length < 4, "Invalid image -  invalid image - too short");
        DomainExceptionValidation.When(image != "" && image.Length > 100, "Invalid image -  invalid image - too long");

        Id = productId;
        Description = description;
        Name = name;
        Price = price;
        Stock = stock;
        Image = image;
    }
}
