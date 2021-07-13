using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioRuta
    {
        Task<IEnumerable<Ruta>> ObtenerTodos();
        Task<Ruta> Obtener(int id);
        Task Guardar(Ruta ruta);
        Task Eliminar(int id);
        Task<Ruta> Obtener(int idC1, int idC2, DateTime hsSalida,int idCom);
        Task<Ruta> Obtener(int idC1, int idC2);
        Task<Ciudad> ObtenerCiudad(int idCiudad);
        Task<IEnumerable<Ruta>> ObtenerTodas(int idC1, int idC2);
    }
}
