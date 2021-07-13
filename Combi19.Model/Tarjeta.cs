using Combi19.Model.Validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Tarjeta
    {
        public Tarjeta()
        {

        }

        public Tarjeta(string numeroTarjeta, string nombreTarjeta, DateTime vencimiento)
        {
            NumeroTarjeta = numeroTarjeta;
            NombreTarjeta = nombreTarjeta;
            Vencimiento = vencimiento;
        }

        [Required(ErrorMessage = "Se debe ingresar un numero de tarjeta.")]
        [StringLength(16, ErrorMessage = "El numero de la tarjeta debe ser de 16 digitos.", MinimumLength = 16)]
        [Display(Name = "NumeroTarjeta")]
        public string NumeroTarjeta { get; set; }
        
        [Required (ErrorMessage ="Ingrese el nombre que figura en la tarjeta")]
        public string NombreTarjeta { get; set; }
        [Required (ErrorMessage="Ingrese la fecha de vencimiento de su tarjeta")]
        [DateValidator]
        public DateTime Vencimiento { get; set; }
        [Required (ErrorMessage ="Ingrese el codigo de 3 digitos la parte trasera su tarjeta ")]
        [MinLength(3, ErrorMessage = "Numero invalido. Ingrese los 3 digitos que estan detras de su tarjeta")]
        [MaxLength(3, ErrorMessage = "Numero invalido. Ingrese los 3 digitos que estan detras de su tarjeta")]
        public string CodigoSeguridad { get; set; }
    }
}
