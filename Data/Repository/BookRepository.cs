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

    public Book? GetByTitle(string title)
    {
        return _context.Books.FirstOrDefault(b => b.Title == title);
    }
    public Book? GetByISBN(string ISBN)
    {
        return _context.Books.FirstOrDefault(b => b.ISBN == ISBN);
    }
    public IEnumerable<Book> FilterByCategory(int categoryId)
    {
        return _context.Books.Where(b => b.CategoryId == categoryId);
    }
}
