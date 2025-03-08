using System.ComponentModel.DataAnnotations;

namespace OrdersWebApp.Validation;

public class DateOnlyFuture : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {

        if (!DateOnly.TryParse(value.ToString(), out DateOnly date))
            return new ValidationResult("Invalid format");

        if (date < DateOnly.FromDateTime(DateTime.Today))
            return new ValidationResult("Date must be in future");

        return ValidationResult.Success;
    }
}
