using Combi19.Data;
using Combi19.Data.Repositorios;
using Combi19.Model;
using Combi19.Ui.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Servicios
{
    public class ServicioPasaje:IServicioPasaje
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioPasaje _RepositorioPasaje;

        public ServicioPasaje(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioPasaje = new RepositorioPasaje(configuration);
        }


        public Task<IEnumerable<Pasaje>> ObtenerTodos()
        {
            return _RepositorioPasaje.ObtenerTodos();
        }
        public Task<IEnumerable<Pasaje>> ObtenerTodosViajes(int idViaje)
        {
            return _RepositorioPasaje.ObtenerTodosViajes(idViaje);
        }
        public Task<IEnumerable<Pasaje>> ObtenerTodos(int idVenta)
        {
            return _RepositorioPasaje.ObtenerTodos(idVenta);
        }

        public Task<Pasaje> Obtener(string dni, int idViaje)
        {
            return _RepositorioPasaje.Obtener(dni, idViaje);
        }
        public Task<Pasaje> ObtenerPasaje(int idPasaje)
        {
            return _RepositorioPasaje.ObtenerPasaje(idPasaje);
        }

        public Task<bool> Guardar(Pasaje pasaje)
        {
                return _RepositorioPasaje.Insertar(pasaje);    
        }

        public Task<bool> CancelarPasaje(Pasaje pasaje)
        {
            return _RepositorioPasaje.CancelarPasaje(pasaje);
        }

        public Task<bool> Confirmar(int id)
        {
            return _RepositorioPasaje.Confirmar(id);
        }

        public Task<bool> PasajeAusente(Pasaje pasaje)
        {
            return _RepositorioPasaje.PasajeAusente(pasaje);
        }

        public Task<Pasaje> ObtenerPendiente(int id)
        {
            return _RepositorioPasaje.ObtenerPendiente(id);
        }
    }
}
