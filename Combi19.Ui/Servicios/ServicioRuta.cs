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
    public class ServicioRuta: IServicioRuta
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioRuta _RepositorioRuta;

        public ServicioRuta(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioRuta = new RepositorioRuta(configuration);
        }

        public Task Eliminar(int id)
        {
            return _RepositorioRuta.Eliminar(id);
        }

        public Task<IEnumerable<Ruta>> ObtenerTodos()
        {
            return _RepositorioRuta.ObtenerTodos();
        }

        public Task<Ruta> Obtener(int id)
        {
            return _RepositorioRuta.Obtener(id);
        }

        public Task Guardar(Ruta ruta)
        {
            if (ruta.Id == 0)
                return _RepositorioRuta.Insertar(ruta);
            else
                return _RepositorioRuta.Actualizar(ruta);
        }

        public Task<Ruta> Obtener(int idC1, int idC2, DateTime hsSalida, int idCom)
        {
            return _RepositorioRuta.Obtener(idC1, idC2, hsSalida, idCom);
        }

        public Task<Ruta> Obtener(int idC1, int idC2)
        {
            return _RepositorioRuta.Obtener(idC1, idC2);
        }

        public Task<Ciudad> ObtenerCiudad(int idCiudad)
        {
            return _RepositorioRuta.ObtenerCiudad(idCiudad);
        }

        public Task<IEnumerable<Ruta>> ObtenerTodas(int idC1, int idC2)
        {
            return _RepositorioRuta.ObtenerTodas(idC1, idC2);
        }
    }
}
