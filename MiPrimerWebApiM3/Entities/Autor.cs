using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimerWebApiM3.Entities
{
    public class Autor
    {

        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo Nombre es requerido!")]
        public string Nombre { get; set; }
    }
}
