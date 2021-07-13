using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioViaje
    {
        Task<IEnumerable<Viaje>> ObtenerTodos();
        Task<Viaje> Obtener(int id);
        Task<Viaje> Obtener(int idR, DateTime fecha);
        Task<Viaje> ViajeEnFecha(int idC, DateTime fecha);
        Task Guardar(Viaje viaje);
        Task Eliminar(int id);
        Task<IEnumerable<Viaje>> ObtenerViajes(int idR, DateTime fecha);
        Task<IEnumerable<Viaje>> ObtenerViajes(DateTime fecha1, DateTime fecha2);
        Task<IEnumerable<Viaje>> ViajesProximos(DateTime fecha);
        Task<IEnumerable<Viaje>> ViajesChofer(int id);
        Task<IEnumerable<Viaje>> ViajesProximosChofer(int id);
        Task<Viaje> ViajeEnCurso(int id);

    }
}
