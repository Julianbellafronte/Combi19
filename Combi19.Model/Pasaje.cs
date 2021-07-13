using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Pasaje
    {
        public Pasaje()
        {

        }
        public Pasaje( string nombre, string apellido, string dni, DateTime fecha)
        {
            Nombre = nombre;
            Apellido = Apellido;
            Dni = dni;
            Fecha = fecha; 
        }
        public int Id { get; set; }
        public int IdVenta { get; set; }
        [Required(ErrorMessage = "Complete este campo")]
        public int IdViaje { get; set; }
        [Required(ErrorMessage = "Complete este campo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Complete este campo")]
        public string Apellido { get; set; }
        [Required (ErrorMessage ="Complete este campo")]
        public string Dni { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        
    }
}
