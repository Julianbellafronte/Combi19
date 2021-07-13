using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Insumo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
    }
}
