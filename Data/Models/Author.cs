using System.ComponentModel.DataAnnotations;

namespace BookNest.Data.Models;

public class Author
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Author Name is Required")]
    public string Name { get; set; }

    [Length(0, 1000, ErrorMessage = "Biography Can NOT be more than 1000 characters")]
    public string? Biography { get; set; }
}
