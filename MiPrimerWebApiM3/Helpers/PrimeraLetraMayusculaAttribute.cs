using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Helpers
{
    public class PrimeraLetraMayusculaAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //a esto lo dejamos exitoso porque esta funcion ya la cumple el atributo Required
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                return ValidationResult.Success;
            }

            //primera letra del valor
            var primeraLetra = value.ToString()[0].ToString();

            if (primeraLetra != primeraLetra.ToUpper())
            {
                return new ValidationResult("La primera letra debe ser mayúscula!");
            }

            return ValidationResult.Success;
        }
    }
}
