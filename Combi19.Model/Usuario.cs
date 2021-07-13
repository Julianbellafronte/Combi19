using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Usuario
    {
        public int IdAux { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Clave { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Dni { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public DateTime FechaNacimiento { get; set; } = DateTime.Today.AddYears(-18);
        [Required (ErrorMessage = "Por favor complete este campo")]
        [Date]
        public bool PlanPremium { get; set; }

        public DateTime FechaSintoma { get; set; }

    }
}
