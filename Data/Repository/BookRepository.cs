using BookNest.Data.IRepository;
using BookNest.Data.Models;

namespace BookNest.Data.Repository;

public class BookRepository : GenaricRepository<Book>, IBookRepository
{
    private readonly BookNestDbContext _context;
    public BookRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }
}
