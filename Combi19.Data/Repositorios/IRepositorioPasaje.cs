using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioPasaje
    {
        Task<IEnumerable<Pasaje>> ObtenerTodos();
        Task<IEnumerable<Pasaje>> ObtenerTodos(int idVenta);
        Task<Pasaje> ObtenerPasaje(int idPasaje);
        Task<IEnumerable<Pasaje>> ObtenerTodosViajes(int idViaje);
        Task<bool> CancelarPasaje(Pasaje pasaje);
        Task<bool> PasajeAusente(Pasaje pasaje);
        Task<Pasaje> Obtener(string dni, int idViaje);
        Task<bool> Insertar(Pasaje pasaje);
        Task<bool> Confirmar(int id);

        Task<Pasaje> ObtenerPendiente(int idr);
    }
}
