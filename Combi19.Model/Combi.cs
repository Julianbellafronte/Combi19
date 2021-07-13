using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Combi
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Patente { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe ingresar un numero de asientos mayor a 0")]
        public int Asientos { get; set; }
        public bool SuperComoda { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe seleccionar un chofer")]
        public int IdChofer { get; set; }
    }
}
