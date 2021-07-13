using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioCombi
    {
        Task<IEnumerable<Combi>> ObtenerTodos();
        Task<Combi> Obtener(int id);
        Task<bool> Eliminar(int id);
        Task<bool> Guardar(Combi combi);
        Task<Combi> ObtenerCombiRuta(int idRuta);

    }
}
