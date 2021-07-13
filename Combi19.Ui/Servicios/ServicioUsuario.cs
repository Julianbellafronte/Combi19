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
    public class ServicioUsuario: IServicioUsuario
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioUsuario _RepositorioUsuario;

        public ServicioUsuario(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioUsuario = new RepositorioUsuario(configuration);
        }

        public Task Eliminar(int id)
        {
            return _RepositorioUsuario.Eliminar(id);
        }

        public Task<IEnumerable<AspNetUsersDto>> ObtenerTodos()
        {
            return _RepositorioUsuario.ObtenerTodos();
        }

        public async Task<AspNetUsersDto> Obtener(int id)
        {
            AspNetUsersDto user= await _RepositorioUsuario.Obtener(id);
            if(!user.PlanPremium)
            {
                user.NombreTarjeta = "";
                user.NumeroTarjeta = "";
                user.Vencimiento = DateTime.Today;
                user.CodigoSeguridad = "";
            }
            return user;
        }

        public Task<IEnumerable<AspNetUsersDto>> Obtener(DateTime fecha1, DateTime fecha2)
        {
            return _RepositorioUsuario.Obtener(fecha1, fecha2);
        }
        public Task<AspNetUsersDto> ExisteEmail(string email)
        {
            return _RepositorioUsuario.ExisteEmail(email);
        }
        public Task<AspNetUsersDto> Obtener(string email, string contraseña)
        {
            return _RepositorioUsuario.Obtener(email, contraseña);
        }

        public Task<Tarjeta> ObtenerTarjeta(int id)
        {
            return _RepositorioUsuario.ObtenerTarjeta(id);
        }

        public Task<AspNetUsersDto> Obtener(string name)
        {
            return _RepositorioUsuario.Obtener(name);
        }

        public Task Guardar(AspNetUsersDto usuario)
        {
            if (usuario.IdAux == 0)
                return _RepositorioUsuario.Insertar(usuario);
            else
                return _RepositorioUsuario.Actualizar(usuario);
        }
    }
}
