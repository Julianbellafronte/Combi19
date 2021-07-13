using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class AspNetUsersDto
    {
        public int IdAux { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [MinLength(7, ErrorMessage = "Ingrese un numero de dni válido")]
        [MaxLength(8, ErrorMessage = "Ingrese un numero de dni válido")]
        public string Dni { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Email { get; set; }
        public string Clave { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool PlanPremium { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Se debe ingresar un numero de tarjeta.")]
        [StringLength(16, ErrorMessage = "El numero de la tarjeta debe ser de 16 digitos.")]
        public string NumeroTarjeta { get; set; }
        [Required(ErrorMessage = "Se debe ingresar un vencimiento.")]
        public DateTime Vencimiento { get; set; }
        [Required(ErrorMessage = "Se debe ingresar un codigo de seguridad.")]
        [StringLength(3, ErrorMessage = "El codigo de seguridad debe ser de 3 digitos.", MinimumLength = 3)]
        public string CodigoSeguridad { get; set; }
        [Required(ErrorMessage = "Se debe ingresar un nombre de tarjeta.")]
        public string NombreTarjeta { get; set; }

        public DateTime FechaSintoma { get; set; }
    }
}
