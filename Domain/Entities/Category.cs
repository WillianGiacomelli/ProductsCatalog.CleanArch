using Domain.Validation;

namespace Domain.Entities;

public sealed class Category : BaseEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public ICollection<Product> Products { get; private set; }

    public Category(int id, string name, string description)
    {
        ValidateCategoryDomain(id, name, description);
    }

    public void Update(int id, string name, string description)
    {
        ValidateCategoryDomain(id, name, description);
    }

    private void ValidateCategoryDomain(int id, string name, string description)
    {
        DomainExceptionValidation.When(id <= 0, "Invalid id -  Id needs to bem greather than 0");
        DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name -  Name is required");
        DomainExceptionValidation.When(name.Length <= 3, "Invalid name -  Name needs to be greater than 4 characters");
        DomainExceptionValidation.When(!string.IsNullOrEmpty(description) && description.Length <= 3, "Invalid description -  Description needs to be greater than 5 characters");

        Id = id;
        Description = description;
        Name = name;

    }
}
