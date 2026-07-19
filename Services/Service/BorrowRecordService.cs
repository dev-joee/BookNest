using BookNest.Data.IRepository;
using BookNest.Data.Models;
using BookNest.Data.Models.Enums;
using BookNest.Services.DTOs;
using BookNest.Services.IService;

namespace BookNest.Services.Service;

public class BorrowRecordService : IBorrowRecordService
{
    private readonly IBookRepository _bookRepository;
    private readonly IUserRecordRepositoy _userRecordRepositoy;
    public BorrowRecordService(IBookRepository bookRepository, IUserRecordRepositoy userRecordRepositoy)
    {
        _bookRepository = bookRepository;
        _userRecordRepositoy = userRecordRepositoy;
    }
    public bool IsAvialable(BookDTO bookDTO)
    {
        return bookDTO.Statue == EnStatue.Available;
    }

    public bool IsBorrowed(BookDTO bookDTO)
    {
        return bookDTO.Statue == EnStatue.Borrowed;
    }

    public void Borrow(int bookId, BookDTO bookDTO, BorrowDTO borrowDTO)
    {
        // Assume that the book is available and not borrowed (check that in controller and return a ModelViewError)
        var book = new Book
        {
            Id = bookId,
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

        book.Quantity -= 1;
        book.Statue = EnStatue.Borrowed;

        _bookRepository.Update(book);
        
        var record = new UserRecord
        {
            Action = EnAction.Borrow,
            ActionDateTime = DateTime.Now            
        };

        _userRecordRepositoy.Create(record);
    }

    public void Return(int bookId, BookDTO bookDTO, ReturnDTO returnDTO)
    {
        var book = new Book
        {
            Id = bookId,
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

        book.Quantity += 1;
        book.Statue = EnStatue.Available;

        _bookRepository.Update(book);

        var record = new UserRecord
        {
            Action = EnAction.Return,
            ActionDateTime = DateTime.Now            
        };

        _userRecordRepositoy.Create(record);
    }
}