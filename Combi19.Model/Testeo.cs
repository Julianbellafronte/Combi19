using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Testeo
    {
        public int Id { get; set; }
        public double Temperatura { get; set; }=36.0;
        public bool Tos { get; set; } = false;
        public int IdPasaje { get; set; }
        public bool Gusto { get; set; } = false;
        public bool Olfato { get; set; } = false;
        public bool DolorGarganta { get; set; } = false;
        public bool Declaracion { get; set; } = false;


    }
}
