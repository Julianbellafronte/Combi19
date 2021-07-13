using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioCiudad
    {
        Task<IEnumerable<Ciudad>> ObtenerTodos();
        Task<Ciudad> Obtener(int id);
        Task<bool> Insertar(Ciudad ciudad);
        Task<bool> Actualizar(Ciudad ciudad);
        Task<bool> Eliminar(int id);
        Task<Ciudad> Obtener(string nombre);
        Task<Provincia> ObtenerProvincia(int idProvincia);
    }
}
