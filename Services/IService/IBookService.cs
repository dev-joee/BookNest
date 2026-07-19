using BookNest.Data.Models;
using BookNest.Services.DTOs;

namespace BookNest.Services.IService;

public interface IBookService
{
    Book AssembleBookObject(BookDTO bookDTO, int id = 0);
    void Add(BookDTO newBookDTO);
    void Edit(int id, BookDTO updatedBookDTO);
    void Delete(int id);
    void UpdateCoverImage(string newCoverImage, int id, BookDTO bookDTO);
    Book? SearchByTitle(string title);
    Book? SearchByISBN(string ISBN);
    IEnumerable<Book> FilterByCategory(int categoryId);
}