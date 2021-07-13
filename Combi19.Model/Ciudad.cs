using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Ciudad
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe seleccionar una provincia")]
        public int IdProvincia { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe ingresar un codigo postal")]
        public string CodigoPostal { get; set; }
    }
}
