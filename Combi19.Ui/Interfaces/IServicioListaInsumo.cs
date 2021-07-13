using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioListaInsumo
    {
        Task<IEnumerable<Insumo>> ObtenerTodos(int idVenta);
        Task Guardar(ListaInsumo lista);
    }
}
