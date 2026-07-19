using BookNest.Data.Models;

namespace BookNest.Data.IRepository;

public interface IBookRepository : IGenaricRepository<Book>
{
    Book? GetByTitle(string title);
    Book? GetByISBN(string ISBN);
    IEnumerable<Book> FilterByCategory(int categoryId);
}
