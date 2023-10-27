using System;
using System.ComponentModel.DataAnnotations;
namespace studentAPI.Validation
{
    public class TenDigitPhoneNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success; // Return success for null values (if null is allowed)
            }

            if (value is int intValue)
            {
                if (intValue >= 1000000000 && intValue <= 9999999999)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("The phone number must be a 10-digit integer.");
        }
    }

}