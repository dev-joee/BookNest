namespace BookNest.Services.DTOs;

public class BorrowDTO
{
    public string Member { get; set; }
    public string Book { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime DueDate { get; set; }
}
