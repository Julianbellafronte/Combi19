using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioCombi
    {
        Task<IEnumerable<Combi>> ObtenerTodos();
        Task<Combi> Obtener(int id);
        Task<bool> Insertar(Combi combi);
        Task<bool> Actualizar(Combi combi);
        Task<bool> Eliminar(int id);
        Task<Combi> ObtenerCombiRuta(int idRuta);
    }
}
