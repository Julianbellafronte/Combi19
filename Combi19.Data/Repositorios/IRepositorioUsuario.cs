using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioUsuario
    {
        Task<IEnumerable<AspNetUsersDto>> ObtenerTodos();
        Task<AspNetUsersDto> Obtener(int id);
        Task<AspNetUsersDto> Obtener(string name);
        Task<IEnumerable<AspNetUsersDto>> Obtener(DateTime fecha1, DateTime fecha2);
        Task<AspNetUsersDto> ExisteEmail(string email);
        Task<AspNetUsersDto> Obtener(string email, string contraseña);
        Task<Tarjeta> ObtenerTarjeta(int id);
        Task<bool> Insertar(AspNetUsersDto usuario);
        Task<bool> Actualizar(AspNetUsersDto usuario);
        Task<bool> Eliminar(int id);
    }
}
