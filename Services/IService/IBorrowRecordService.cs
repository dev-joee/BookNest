using BookNest.Services.DTOs;

namespace BookNest.Services.IService;

public interface IBorrowRecordService
{
    bool IsAvialable(BookDTO bookDTO);
    bool IsBorrowed(BookDTO bookDTO);
    void Borrow(int bookId, BookDTO bookDTO, BorrowDTO borrowDTO);
    void Return(int bookId, BookDTO bookDTO, ReturnDTO returnDTO);
}