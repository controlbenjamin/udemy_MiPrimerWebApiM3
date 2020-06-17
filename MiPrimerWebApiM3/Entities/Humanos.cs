using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Entities
{
    public class Humanos : IValidatableObject
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(Nombre))
            {

                var primeraLetra = Nombre[0].ToString();

                if (primeraLetra != primeraLetra.ToUpper())
                {

                    yield return new ValidationResult("La primera letra deber estar en mayúscula!", new string[] { nameof(Nombre) });
                }

                if (Edad < 18)
                {
                    yield return new ValidationResult("Debe ser mayor de edad!", new string[] { nameof(Edad) });
                }
            }
        }
    }
}
