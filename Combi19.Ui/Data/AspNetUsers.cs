using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Data
{
    public class AspNetUsers : IdentityUser
    {
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Dni { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public DateTime FechaNacimiento { get; set; }
        public bool PlanPremium { get; set; }
        public string NumeroTarjeta { get; set; }
        public DateTime Vencimiento { get; set; }
        public string CodigoSeguridad { get; set; }
        public string NombreTarjeta { get; set; }
    }

}
