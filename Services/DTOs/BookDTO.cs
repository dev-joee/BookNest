using BookNest.Data.Models.Enums;

namespace BookNest.Services.DTOs;

public class BookDTO
{
    public string BookTitle { get; set; }
    public string BookISBN { get; set; }
    public string BookDescription { get; set; }
    public int BookQuantity { get; set; }
    public string BookCoverImage { get; set; }
    public int BookCategoryId { get; set; }
    public int AuthorId { get; set; }
    public EnStatue Statue { get; set; }

}
