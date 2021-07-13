using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioViaje
    {
        Task<IEnumerable<Viaje>> ObtenerTodos();
        Task<Viaje> Obtener(int id);
        Task<Viaje> ViajeEnFecha(int idC, DateTime fecha);
        Task<Viaje> Obtener(int idR, DateTime fecha);
        Task<bool> Insertar(Viaje viaje);
        Task<bool> Actualizar(Viaje viaje);
        Task<bool> Eliminar(int id);
        Task<IEnumerable<Viaje>> ObtenerViajes(int idR, DateTime fecha);
        Task<IEnumerable<Viaje>> ObtenerViajes(DateTime fecha1, DateTime fecha2);
        Task<IEnumerable<Viaje>> ViajesProximos(DateTime fecha);
        public Task<IEnumerable<Viaje>> ViajesChofer(int idChofer);
        public Task<IEnumerable<Viaje>> ViajesProximosChofer(int idChofer);

        Task<Viaje> ViajeEnCurso(int id);
       
    }
}
