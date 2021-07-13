using Combi19.Model.Validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Viaje
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe seleccionar una ruta")]
        public int IdRuta { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [DateValidator]
        public DateTime FechaSalida { get; set; } = DateTime.Today;
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe ingresar un precio mayor a 0")]
        public double Precio { get; set; }
        public int Asientos { get; set; }
        public string Estado { get; set; } = "Pendiente";
    }
}
