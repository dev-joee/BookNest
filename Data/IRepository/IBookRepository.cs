using BookNest.Data.Models;

namespace BookNest.Data.IRepository;

public interface IBookRepository : IGenaricRepository<Book>
{
    Task<Book?> GetByTitleAsync(string title);
    Task<Book?> GetByISBNAsync(string isbn);
    Task<List<Book>> FilterByCategoryAsync(int categoryId);
    IEnumerable<Book> GetAll();
}