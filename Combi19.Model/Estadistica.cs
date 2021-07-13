using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Estadistica
    {
        public Estadistica()
        {
            Opcion = "Seleccione una opcion";
        }
        public string Opcion { get; set; }
        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }
    }
}
