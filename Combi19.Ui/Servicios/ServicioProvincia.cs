using Combi19.Data;
using Combi19.Data.Repositorios;
using Combi19.Model;
using Combi19.Ui.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Combi19.Ui.Servicios
{
    public class ServicioProvincia: IServicioProvincia
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioProvincia _RepositorioProvincia;

        public ServicioProvincia(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioProvincia = new RepositorioProvincia(configuration);
        }

        public Task<IEnumerable<Provincia>> ObtenerTodos()
        {
            return _RepositorioProvincia.ObtenerTodos();
        }

        public Task<Provincia> Obtener(int id)
        {
            return _RepositorioProvincia.Obtener(id);
        }
    }
}
