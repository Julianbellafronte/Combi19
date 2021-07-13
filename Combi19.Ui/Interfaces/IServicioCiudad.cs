using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioCiudad
    {
        Task<IEnumerable<Ciudad>> ObtenerTodos();
        Task<Ciudad> Obtener(int id);
        Task Guardar(Ciudad ciudad);
        Task Eliminar(int id);
        Task<Ciudad> Obtener(string nombre);
        Task<Provincia> ObtenerProvincia(int idProvincia);
    }
}
