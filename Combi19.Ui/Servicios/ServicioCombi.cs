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
    public class ServicioCombi : IServicioCombi
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioCombi _RepositorioCombi;

        public ServicioCombi(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioCombi = new RepositorioCombi(configuration);
        }

        public Task<IEnumerable<Combi>> ObtenerTodos()
        {
            return _RepositorioCombi.ObtenerTodos();
        }

        public Task<Combi> Obtener(int id)
        {
            return _RepositorioCombi.Obtener(id);
        }

        public Task<bool> Guardar(Combi combi)
        {
            if (combi.Id == 0)
            {
                return _RepositorioCombi.Insertar(combi);
            }
            else
                return _RepositorioCombi.Actualizar(combi);
        }

        public Task<bool> Eliminar(int id)
        {
            return _RepositorioCombi.Eliminar(id);
        }

        public Task<Combi> ObtenerCombiRuta(int idRuta)
        {
            return _RepositorioCombi.ObtenerCombiRuta(idRuta);
        }
    }
}
