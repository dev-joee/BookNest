using BookNest.Data.IRepository;
using BookNest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookNest.Data.Repository;

public class CategoryRepository : GenaricRepository<Category>, ICategoryRepository
{
    private readonly BookNestDbContext _context;

    public CategoryRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Category?> SearchByNameAsync(string name)
    {
        return await _context.Categories
            .FirstOrDefaultAsync(c => c.Name == name);
    }
}