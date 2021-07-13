using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Interfaces
{
    public interface IServicioVenta
    {
        Task<IEnumerable<Venta>> ObtenerTodos();
        Task<IEnumerable<Venta>> ObtenerTodos(int idUser);
        Task<IEnumerable<Venta>> ObtenerVentas(DateTime fecha1, DateTime fecha2);
        Task<Venta> Obtener(int id);
        Task<Row> Guardar(Venta venta);
        public Task<bool> Actualizar(Venta venta);
        Task<Venta> VentaViaje(int idV);
        Task Eliminar(int id,double valor);
        Task<Venta> ObtenerVentaComprador(int idComprador);
        Task<bool> Denegar(int id);
    }
}
