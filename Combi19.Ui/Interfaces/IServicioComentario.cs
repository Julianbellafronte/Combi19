using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioComentario
    {
        Task<IEnumerable<Comentario>> ObtenerTodos();
        Task<IEnumerable<Comentario>> ObtenerTodosUsuario(int idU);
        Task<IEnumerable<Comentario>> ObtenerDestacados();
        Task<Comentario> Obtener(int id);
        Task<bool> Eliminar(int id);
        Task<bool> Guardar(Comentario comentario);
    }
}
