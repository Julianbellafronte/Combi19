using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioInsumo
    {
        Task<IEnumerable<Insumo>> ObtenerTodos();
        Task<Insumo> Obtener(int id);
        Task Guardar(Insumo insumo);
        Task Eliminar(int id);
        Task<Insumo> Existe(string cod);
    }
}
