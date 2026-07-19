using BookNest.Data.IRepository;
using BookNest.Data.Models;
using BookNest.Data.Models.Enums;
using BookNest.Services.DTOs;
using BookNest.Services.IService;

namespace BookNest.Services.Service;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;
    private readonly ICategoryRepository _categoryRepository;
    public BookService(IBookRepository bookRepository, ICategoryRepository categoryRepository)
    {
        _bookRepository = bookRepository;
        _categoryRepository = categoryRepository;
    }
    public Book AssembleBookObject(BookDTO bookDTO, int id = 0)
    {
        return new Book
        {
            Id = id,
            Title = bookDTO.BookTitle,
            ISBN = bookDTO.BookISBN,
            Description = bookDTO.BookDescription,
            PublicationDate = DateTime.Now,
            Quantity = bookDTO.BookQuantity,
            CoverImage = bookDTO.BookCoverImage,
            CategoryId = bookDTO.BookCategoryId,
            AuthorId = bookDTO.AuthorId,
            Statue = EnStatue.Available
        };
    }
    public void Add(BookDTO newBookDTO)
    {
        var book = AssembleBookObject(newBookDTO); 

        try
        {
            _bookRepository.Create(book);
            _bookRepository.Save();
        } catch (Exception ex)
        {
            throw new Exception(ex.Message);            
        }
    }
    public void Edit(int id, BookDTO updatedBookDTO)
    {
        var book = AssembleBookObject(updatedBookDTO, id);

        try
        {
            _bookRepository.Update(book);
            _bookRepository.Save();
        } catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    public void Delete(int id)
    {
        try
        {
            _bookRepository.DeleteById(id);
            _bookRepository.Save();
        } catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }        
    }
    public void UpdateCoverImage(string newCoverImage, int id, BookDTO bookDTO)
    {
        bookDTO.BookCoverImage = newCoverImage;
        this.Edit(id, bookDTO);
    }
    public Book? SearchByTitle(string title)
    {
        return _bookRepository.GetByTitle(title);   
    }
    public Book? SearchByISBN(string ISBN)
    {
        return _bookRepository.GetByISBN(ISBN);   
    }
    public IEnumerable<Book> FilterByCategory(int categoryId)
    {
        return _bookRepository.FilterByCategory(categoryId);
    }
}
