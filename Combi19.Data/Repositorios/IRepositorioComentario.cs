using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioComentario
    {
        Task<IEnumerable<Comentario>> ObtenerTodos();
        Task<IEnumerable<Comentario>> ObtenerDestacados();
        Task<IEnumerable<Comentario>> ObtenerTodosUsuario(int idU);
        Task<Comentario> Obtener(int id);
        Task<bool> Insertar(Comentario comentario);
        Task<bool> Actualizar(Comentario comentario);
        Task<bool> Eliminar(int id);
    }
}
