using System.ComponentModel.DataAnnotations;

namespace BookNest.Data.Models;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Length(0, 50, ErrorMessage = "Name can NOT be more than 50 characters")]
    public string Name { get; set; }
    
    public string? Description { get; set; }
}
