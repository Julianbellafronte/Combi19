using Combi19.Model;
using Combi19.Ui.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioUsuario
    {
        Task<IEnumerable<AspNetUsersDto>> ObtenerTodos();
        Task<AspNetUsersDto> Obtener(int id);
        Task<AspNetUsersDto> Obtener(string name);
        Task<IEnumerable<AspNetUsersDto>> Obtener(DateTime fecha1, DateTime fecha2);
        Task<AspNetUsersDto> ExisteEmail(string email);
        Task<AspNetUsersDto> Obtener(string email, string contraseña);
        Task Guardar(AspNetUsersDto usuario);
        Task Eliminar(int id);
        Task<Tarjeta> ObtenerTarjeta(int id);
    }
}
