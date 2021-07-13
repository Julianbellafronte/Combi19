using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioInsumo
    {
        Task<IEnumerable<Insumo>> ObtenerTodos();
        Task<Insumo> Obtener(int id);
        Task<bool> Insertar(Insumo insumo);
        Task<bool> Actualizar(Insumo insumo);
        Task<bool> Eliminar(int id);
        Task<Insumo> Existe(string cod);
    }
}
