using Combi19.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioChofer
    {
        Task<IEnumerable<AspNetUsersDto>> ObtenerTodos();
        Task<AspNetUsersDto> Obtener(int id);
        Task<AspNetUsersDto> Obtener(string name);
        Task<AspNetUsersDto> Obtener(string email, string contraseña);
        Task Guardar(AspNetUsersDto chofer);
        Task Eliminar(int id);
        Task<AspNetUsersDto> TieneCombi(int id);
        Task<AspNetUsersDto> ExisteEmail(string Email);
        Task<IEnumerable<AspNetUsersDto>> ObtenerTodosSinCombi();
    }
}
