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
    public class ServicioTesteo: IServicioTesteo
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioTesteo _RepositorioTesteo;

        public ServicioTesteo(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioTesteo = new RepositorioTesteo(configuration);
        }

        public Task<IEnumerable<Testeo>> ObtenerTodos()
        {
            return _RepositorioTesteo.ObtenerTodos();
        }

        public Task<bool> Guardar(Testeo testeo)
        {
            return _RepositorioTesteo.Insertar(testeo);
        }

        public Task<Testeo> Obtener(int id)
        {
            return _RepositorioTesteo.Obtener(id);
        }
    }
}
