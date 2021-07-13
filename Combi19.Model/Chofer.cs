using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Chofer
    {
        //Holaa
        public int IdAux { get; set; }
        [Required (ErrorMessage ="Por favor complete este campo")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [MinLength(6, ErrorMessage ="La contraseña debe contener al menos 6 caracteres")]
        public string Clave { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Dni { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Telefono { get; set; }


    }
}
