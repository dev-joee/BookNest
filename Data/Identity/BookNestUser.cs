using Microsoft.AspNetCore.Identity;
using BookNest.Data.Validation;

namespace BookNest;

public class BookNestUser : IdentityUser
{
    [RoleExists]
    public string Role { get; set; }    
}
