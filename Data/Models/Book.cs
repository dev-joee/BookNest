using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BookNest.Data.Models.Enums;
using BookNest.Data.Validation;

namespace BookNest.Data.Models;

public class Book
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Book Title is Required")]
    public string Title { get; set; }
    
    [Required(ErrorMessage = "Book ISBN is Required")]
    [Unique] // Custom Validator Attribue (will be implemented later)
    public string ISBN { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime? PublicationDate { get; set; }
    
    [Range(minimum:0, maximum:int.MaxValue)]
    public int? Quantity { get; set; }
    
    [RegularExpression(@"^.*\.(png|jpg)$", ErrorMessage = "Image must be JPG or PNG only")]
    public string? CoverImage { get; set; }

    public EnStatue Statue { get; set; }

    // Relations
    [ForeignKey("BorrowRecord")]
    public int? BoorowRecordId { get; set; }
    public BorrowRecord? BorrowRecord { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    [ForeignKey("Author")]
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}
