using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KnittingCore2.Models
{
    public class CustomTitleValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var patrones = (Patrones)validationContext.ObjectInstance;

            if (patrones.IdAutorPatron != 0)
            {
                if (value == null || string.IsNullOrEmpty(value.ToString()))
                {
                    // Oops!
                    return new ValidationResult(validationContext.DisplayName + " es un campo obligatorio");
                }
            }

            // Ok!
            return ValidationResult.Success;
        }

    }
}
