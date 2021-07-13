using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioListaInsumo
    {
        Task<IEnumerable<Insumo>> ObtenerTodos(int idVenta);
        Task<bool> Insertar(ListaInsumo lista);
    }
}
