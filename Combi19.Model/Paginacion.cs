using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Paginacion
    {
        public int Pagina { get; set; } = 1;
        public int Registros { get; set; } = 3;
        public int TotalPaginas { get; set; }
    }
}
