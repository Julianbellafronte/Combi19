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
    public class ServicioCiudad: IServicioCiudad
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioCiudad _RepositorioCiudad;

        public ServicioCiudad(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioCiudad = new RepositorioCiudad(configuration);
        }

        public Task Eliminar(int id)
        {
            return _RepositorioCiudad.Eliminar(id);
        }

        public Task<IEnumerable<Ciudad>> ObtenerTodos()
        {
            return _RepositorioCiudad.ObtenerTodos();
        }

        public Task<Ciudad> Obtener(int id)
        {
            return _RepositorioCiudad.Obtener(id);
        }
        public Task<Ciudad> Obtener(string nombre)
        {
            return _RepositorioCiudad.Obtener(nombre);
        }

        public Task Guardar(Ciudad ciudad)
        {

            if (ciudad.Id == 0)
                return _RepositorioCiudad.Insertar(ciudad);
            else
                return _RepositorioCiudad.Actualizar(ciudad);
        }

        public Task<Provincia> ObtenerProvincia(int idProvincia)
        {
            return _RepositorioCiudad.ObtenerProvincia(idProvincia);
        }
        

    }
}
