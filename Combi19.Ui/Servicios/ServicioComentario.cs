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
    public class ServicioComentario : IServicioComentario
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioComentario _RepositorioComentario;

        public ServicioComentario(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioComentario = new RepositorioComentario(configuration);
        }

        public Task<IEnumerable<Comentario>> ObtenerTodos()
        {
            return _RepositorioComentario.ObtenerTodos();
        }

        public Task<IEnumerable<Comentario>> ObtenerTodosUsuario(int idU) {
            return _RepositorioComentario.ObtenerTodosUsuario(idU);
        }

        public Task<IEnumerable<Comentario>> ObtenerDestacados()
        {
            return _RepositorioComentario.ObtenerDestacados();
        }


        public Task<Comentario> Obtener(int id)
        {
            return _RepositorioComentario.Obtener(id);
        }

        public Task<bool> Guardar(Comentario comentario)
        {
            if (comentario.Id == 0)
            {
                return _RepositorioComentario.Insertar(comentario);
            }
            else
                return _RepositorioComentario.Actualizar(comentario);
        }

        public Task<bool> Eliminar(int id)
        {
            return _RepositorioComentario.Eliminar(id);
        }
    }
}
