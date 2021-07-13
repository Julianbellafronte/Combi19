using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioTesteo
    {
        Task<IEnumerable<Testeo>> ObtenerTodos();
        Task<Testeo> Obtener(int id);
        Task<bool> Guardar(Testeo testeo);
    }
}
