using System.ComponentModel.DataAnnotations;
using BookNest.Data.Repository;
using BookNest.Data.Models;

namespace BookNest.Data.Validation;

public class UniqueAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var BookRepository = validationContext.GetService<BookRepository>();

        if (BookRepository == null)
        {
            throw new InvalidOperationException("BookRepository is not registered.");
        }

        var Object = (Book) validationContext.ObjectInstance;

        var Books = BookRepository.GetAll();

        foreach (var item in Books)
        {
            if (item.ISBN == (string)value && item.Id != Object.Id)
            {
                return new ValidationResult($"ISBN of that book already exists [book id {item.Id}]");
            }
        }

        return ValidationResult.Success;
    }
}
