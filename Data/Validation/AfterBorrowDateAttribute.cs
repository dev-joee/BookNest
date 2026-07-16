using System.ComponentModel.DataAnnotations;
using BookNest.Data.Models;

namespace BookNest.Data.Validation;

public class AfterBorrowDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var BorrowRecord = (BorrowRecord) validationContext.ObjectInstance;

        if (DateTime.Compare((DateTime)value, BorrowRecord.BorrowDate) == 1) // value (Due Date) > Borrow Date 
        {
            return ValidationResult.Success;
        }

        return new ValidationResult("Due Date Must Come After Borrow Date");
    }
}
