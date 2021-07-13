using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Comentario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public string Contenido { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        public int IdCreador { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string NombreCreador { get; set; }

        public event Action RefreshRequested;
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }

}
