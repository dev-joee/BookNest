using BookNest.Data.IRepository;
using BookNest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookNest.Data.Repository;

public class AuthorRepository : GenaricRepository<Author>, IAuthorRepository
{
    private readonly BookNestDbContext _context;

    public AuthorRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Author?> SearchByNameAsync(string name)
    {
        return await _context.Authors
            .FirstOrDefaultAsync(a => a.Name == name);
    }
}