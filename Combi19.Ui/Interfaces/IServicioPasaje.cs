using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioPasaje
    {
        Task<IEnumerable<Pasaje>> ObtenerTodos();
        Task<IEnumerable<Pasaje>> ObtenerTodos(int idVenta);
        Task<IEnumerable<Pasaje>> ObtenerTodosViajes(int idViaje);
        Task<Pasaje> Obtener(string dni, int idViaje);
        Task<Pasaje> ObtenerPasaje(int idPasaje);
        Task<bool> Guardar(Pasaje pasaje);
        Task<bool> CancelarPasaje(Pasaje pasaje);
        Task<bool> PasajeAusente(Pasaje pasaje);
        Task<bool> Confirmar(int id);
        Task<Pasaje> ObtenerPendiente(int id);
    }
}
