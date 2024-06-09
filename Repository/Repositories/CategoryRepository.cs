using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;
    public CategoryRepository(ApplicationDbContext _categoryContext)
    {
        _context = _categoryContext;
    }

    public async Task<Category> Create(Category category)
    {
        _context.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<Category> Delete(Category category)
    {
        _context.Remove(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<Category> GetCategoriesByIdAsync(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public async Task<IEnumerable<Category>> GetCategoryiesAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<IEnumerable<Category>> GetProductsCategoryAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Category> Update(Category Category)
    {
        _context.Update(Category);
        await _context.SaveChangesAsync();
        return Category;
    }
}
