using BookNest.Data.IRepository;
using BookNest.Data.Models;

namespace BookNest.Data.Repository;

public class AuthorRepository : GenaricRepository<Author>, IAuthorRepository
{
    private readonly BookNestDbContext _context;
    public AuthorRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }
}
