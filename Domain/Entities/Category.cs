using Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public sealed class Category
{
    public int CategoryId { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ICollection<Product> Products { get; private set; }

    public Category(string name, string description)
    {
        ValidateCategoryDomain(name);
        Description = description;
    }

    public Category(int id, string name, string description)
    {
        CategoryId = id;
        Name = name;
        Description = description;
    }

    private void ValidateCategoryDomain(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name -  Name is required");

        DomainExceptionValidation.When(name.Length <= 3, "Invalid name -  Name needs to be greater than 4 characters");
        Name = name;
    }
}
