using BookNest.Data.IRepository;
using BookNest.Data.Models;

namespace BookNest.Data.Repository;

public class CategoryRepository : GenaricRepository<Category>, ICategoryRepository
{
    private readonly BookNestDbContext _context;
    public CategoryRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }
}
