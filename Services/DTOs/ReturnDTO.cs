namespace BookNest.Services.DTOs;

public class ReturnDTO
{
    public BorrowDTO BorrowedRecordDTO { get; set; }
    public DateTime ReturnDate { get; set; }
}
