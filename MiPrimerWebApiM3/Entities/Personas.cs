using MiPrimerWebApiM3.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Entities
{
    public class Personas
    {

        public int Id { get; set; }

        [Required]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }


        [Required]
        [EmailAddress(ErrorMessage = "Introduzca un email válido")]
        public string Email { get; set; }

        [Range(18,100)]
        public int Edad { get; set; }
    }
}
