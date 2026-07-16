using System.ComponentModel.DataAnnotations;

namespace BookNest.Data.Models;

public class Member
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "First Name is Required")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Last Name is Required")]
    public string LastName { get; set; }
    
    [Required(ErrorMessage = "Email is Required")]
    [EmailAddress]
    public string Email { get; set; }
    
    [Required(ErrorMessage = "Phone Number is Required")]
    public string PhoneNumber { get; set; }

    public string? Address { get; set; }
    
    public DateTime DateOfBirth { get; set; }
}
