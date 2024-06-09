using Domain.Entities;

namespace Domain.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetCategoryiesAsync();
    Task<Category> GetCategoriesByIdAsync(int id);

    Task<IEnumerable<Category>> GetProductsCategoryAsync();
    Task<Category> Create(Category Category);
    Task<Category> Update(Category Category);
    Task<Category> Delete(Category Category);
}
