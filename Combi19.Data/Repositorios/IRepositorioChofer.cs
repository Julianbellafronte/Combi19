using Combi19.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioChofer
    {
        Task<IEnumerable<AspNetUsersDto>> ObtenerTodos();
        Task<AspNetUsersDto> Obtener(int id);
        Task<AspNetUsersDto> Obtener(string email, string contraseña);
        Task<bool> Insertar(AspNetUsersDto chofer);
        Task<bool> Actualizar(AspNetUsersDto chofer);
        Task<bool> Eliminar(int id);
        Task<AspNetUsersDto> TieneCombi(int id);
        Task<AspNetUsersDto> ExisteEmail(string email);
        Task<IEnumerable<AspNetUsersDto>> ObtenerTodosSinCombi();
        public Task<AspNetUsersDto> Obtener(string name);
    }
}
