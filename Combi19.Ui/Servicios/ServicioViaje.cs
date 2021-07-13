using Combi19.Data;
using Combi19.Data.Repositorios;
using Combi19.Model;
using Combi19.Ui.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Combi19.Ui.Servicios
{
    public class ServicioViaje: IServicioViaje
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioViaje _RepositorioViaje;

        public ServicioViaje(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioViaje = new RepositorioViaje(configuration);
        }

        public Task Eliminar(int id)
        {
            return _RepositorioViaje.Eliminar(id);
        }

        public Task<IEnumerable<Viaje>> ObtenerTodos()
        {
            return _RepositorioViaje.ObtenerTodos();
        }

        public Task<Viaje> Obtener(int id)
        {
            return _RepositorioViaje.Obtener(id);
        }

        public Task<Viaje> ViajeEnFecha(int idC, DateTime fecha)
        {
            return _RepositorioViaje.ViajeEnFecha (idC,fecha);
        }
        public Task Guardar(Viaje viaje)
        {
            if (viaje.Id == 0)
                return _RepositorioViaje.Insertar(viaje);
            else
                return _RepositorioViaje.Actualizar(viaje);
        } 
        public Task<IEnumerable<Viaje>> ObtenerViajes(int idR, DateTime fecha)
        {
            return _RepositorioViaje.ObtenerViajes(idR, fecha);
        }
        public Task<IEnumerable<Viaje>> ObtenerViajes(DateTime fecha1, DateTime fecha2)
        {
            return _RepositorioViaje.ObtenerViajes(fecha1, fecha2);
        }

        public Task<Viaje> Obtener(int idR, DateTime fecha)
        {
            return _RepositorioViaje.Obtener(idR, fecha);
        }
        public Task<IEnumerable<Viaje>> ViajesProximos(DateTime fecha)
        {
            return _RepositorioViaje.ViajesProximos(fecha);
        }

        public Task<IEnumerable<Viaje>> ViajesChofer(int id)
        {
            return _RepositorioViaje.ViajesChofer(id);
        }

        public Task<IEnumerable<Viaje>> ViajesProximosChofer(int idChofer)
        {
            return _RepositorioViaje.ViajesProximosChofer(idChofer);
        }

        public Task<Viaje> ViajeEnCurso(int id)
        {
            return _RepositorioViaje.ViajeEnCurso(id);
        }
       
    }
}
