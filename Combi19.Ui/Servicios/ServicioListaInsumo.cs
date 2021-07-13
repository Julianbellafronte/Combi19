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
    public class ServicioListaInsumo : IServicioListaInsumo
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioListaInsumo _RepositorioListaInsumo;

        public ServicioListaInsumo(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioListaInsumo = new RepositorioListaInsumo(configuration);
        }
        public Task Guardar(ListaInsumo lista)
        {
            return _RepositorioListaInsumo.Insertar(lista);
        }

        public Task<IEnumerable<Insumo>> ObtenerTodos(int idVenta)
        {
            return _RepositorioListaInsumo.ObtenerTodos(idVenta);
        }
    }
}
