using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioRuta
    {
        Task<IEnumerable<Ruta>> ObtenerTodos();
        Task<Ruta> Obtener(int id);
        Task<bool> Insertar(Ruta ruta);
        Task<bool> Actualizar(Ruta ruta);
        Task<bool> Eliminar(int id);
        Task<Ruta> Obtener(int idC1, int idC2, DateTime hsSalida, int idCom);
        Task<Ruta> Obtener(int idC1, int idC2);
        Task<IEnumerable<Ruta>> ObtenerTodas(int idC1, int idC2);
        Task<Ciudad> ObtenerCiudad(int idCiudad); 
    }
}
