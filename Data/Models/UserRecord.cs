using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using BookNest.Data.Models.Enums;

namespace BookNest.Data.Models;

public class UserRecord
{
    [Key]
    public int Id { get; set; }
    public EnAction Action { get; set; }
    
    [ForeignKey("BookNestUser")]
    public string UserId { get; set; }
    public BookNestUser? User { get; set; }

    [ForeignKey("Member")]
    public int MemberId { get; set; }
    public Member? Member { get; set; }

    [ForeignKey("Book")]
    public int BookId { get; set; }
    public Book? Book { get; set; }
}
