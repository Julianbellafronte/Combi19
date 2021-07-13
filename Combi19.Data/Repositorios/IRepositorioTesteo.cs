using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
   public interface IRepositorioTesteo
    {
        Task<IEnumerable<Testeo>> ObtenerTodos();
        Task<Testeo> Obtener(int id);
        Task<bool> Insertar(Testeo testeo);
    }
}
