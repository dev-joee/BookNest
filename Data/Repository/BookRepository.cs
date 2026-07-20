using BookNest.Data.IRepository;
using BookNest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookNest.Data.Repository;

public class BookRepository : GenaricRepository<Book>, IBookRepository
{
    private readonly BookNestDbContext _context;

    public BookRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Book?> GetByTitleAsync(string title)
    {
        return await _context.Books
            .FirstOrDefaultAsync(b => b.Title == title);
    }

    public async Task<Book?> GetByISBNAsync(string isbn)
    {
        return await _context.Books
            .FirstOrDefaultAsync(b => b.ISBN == isbn);
    }

    public async Task<List<Book>> FilterByCategoryAsync(int categoryId)
    {
        return await _context.Books
            .Where(b => b.CategoryId == categoryId)
            .ToListAsync();
    }
}