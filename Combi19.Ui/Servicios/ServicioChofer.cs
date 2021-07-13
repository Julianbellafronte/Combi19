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
    public class ServicioChofer: IServicioChofer 
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioChofer _RepositorioChofer;

        public ServicioChofer(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioChofer = new RepositorioChofer(configuration);
        }

        public Task Eliminar(int id)
        {
            return _RepositorioChofer.Eliminar(id);
        }

        public Task<IEnumerable<AspNetUsersDto>> ObtenerTodos()
        {
            return _RepositorioChofer.ObtenerTodos();
        }

        public  Task<AspNetUsersDto> Obtener(int id)
        {
            return _RepositorioChofer.Obtener(id);
        }

        public Task<AspNetUsersDto> Obtener(string name)
        {
            return _RepositorioChofer.Obtener(name);
        }

        public Task<AspNetUsersDto> Obtener(string email, string contraseña)
        {
            return _RepositorioChofer.Obtener(email, contraseña);
        }

        public Task Guardar(AspNetUsersDto chofer)
        {
             return _RepositorioChofer.Actualizar(chofer);
        }

        public Task<AspNetUsersDto> TieneCombi(int id)
        {
            return _RepositorioChofer.TieneCombi(id);
        }

        public Task<AspNetUsersDto> ExisteEmail(string email)
        {
            return _RepositorioChofer.ExisteEmail(email);
        }
        public Task<IEnumerable<AspNetUsersDto>> ObtenerTodosSinCombi()
        {
            return _RepositorioChofer.ObtenerTodosSinCombi();
        }
    }
}
