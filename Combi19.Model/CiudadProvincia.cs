using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class CiudadProvincia
    {
        public Ciudad ciudad { get; set; }
        public Provincia provincia { get; set; }

        public CiudadProvincia(int idCiudad, string nombreCiudad, int idProvincia, string codigoP, string nombreProvincia)
        {
            ciudad = new Ciudad();
            ciudad.Id = idCiudad;
            ciudad.Nombre = nombreCiudad;
            ciudad.IdProvincia = idProvincia;
            ciudad.CodigoPostal = codigoP;

            provincia = new Provincia();
            provincia.Id = idProvincia;
            provincia.Nombre = nombreProvincia;
        }
    }
}
