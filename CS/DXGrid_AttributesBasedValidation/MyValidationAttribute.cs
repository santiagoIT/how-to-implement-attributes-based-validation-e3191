using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXGrid_AttributesBasedValidation
{
  public class MyValidationAttributeValidationAttribute : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      if (value is double doubleValue)
      {
        if (doubleValue > 100)
        {

          return new ValidationResult("Value must be less than 100", new List<string> { validationContext.DisplayName });
        }
      }

      return ValidationResult.Success;
    }

    public override bool RequiresValidationContext => true;
  }
}
