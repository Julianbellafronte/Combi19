using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Ruta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe seleccionar una ciudad origen")]
        public int IdCiudad1 { get; set; } = 0;
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe seleccionar una ciudad destino")]

        public int IdCiudad2 { get; set; } = 0;
        [Required(ErrorMessage = "Por favor complete este campo")]
        public double Km { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public DateTime HsSalida { get; set; }= DateTime.Now;
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage ="Se debe seleccionar una combi")]
        public int IdCombi { get; set; }
    }
}
