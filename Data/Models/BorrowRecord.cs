using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookNest.Data.Models.Enums;
using BookNest.Data.Validation;

namespace BookNest.Data.Models;

public class BorrowRecord
{
    [Key]
    public int Id { get; set; }

    public DateTime BorrowDate { get; set; }
    
    [AfterBorrowDate]
    public DateTime DueDate { get; set; }
    
    public DateTime ReturnDate { get; set; }

    // Reletions
    [ForeignKey("Member")]
    public int MemnerId { get; set; }
    public Member? Member { get; set; }
}
