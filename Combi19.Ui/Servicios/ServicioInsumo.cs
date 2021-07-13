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
    public class ServicioInsumo: IServicioInsumo
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioInsumo _RepositorioInsumo;

        public ServicioInsumo(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioInsumo = new RepositorioInsumo(configuration);
        }

        public Task Eliminar(int id)
        {
            return _RepositorioInsumo.Eliminar(id);
        }

        public Task<IEnumerable<Insumo>> ObtenerTodos()
        {
            return _RepositorioInsumo.ObtenerTodos();
        }

        public Task<Insumo> Obtener(int id)
        {
            return _RepositorioInsumo.Obtener(id);
        }

        public Task Guardar(Insumo insumo)
        {
            if (insumo.Id == 0)
                return _RepositorioInsumo.Insertar(insumo);
            else
                return _RepositorioInsumo.Actualizar(insumo);
        }

        public Task<Insumo> Existe(string cod)
        {
            return _RepositorioInsumo.Existe(cod);
        }
    }
}
