using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Resumen
    {
        public Resumen(List<Pasaje> pasajes, List<Insumo> insumos) {
            PasajesInfo = pasajes;
            InsumosSeleccionados = insumos;
        }

        public Resumen()
        {

        }

        public List<Pasaje> PasajesInfo { get; set; }
        public List<Insumo> InsumosSeleccionados { get; set; }
    }
    
}
