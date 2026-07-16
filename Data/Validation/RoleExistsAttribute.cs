using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BookNest.Data.Validation;

public class RoleExistsAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var RoleManager = validationContext.GetService<RoleManager<IdentityRole>>();

        foreach (var item in RoleManager.Roles)
        {
            if ((string) value == item.Name)
            {
                return ValidationResult.Success;
            }
        }

        return new ValidationResult("This Role Does Not Exists in System Roles");
    }
}
