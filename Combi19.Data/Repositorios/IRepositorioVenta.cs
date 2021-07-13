using Combi19.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public interface IRepositorioVenta
    {
        Task<IEnumerable<Venta>> ObtenerTodos();
        Task<IEnumerable<Venta>> ObtenerTodos(int idUser);
        Task<Venta> Obtener(int id);
        Task<Row> Insertar(Venta venta);
        Task<Row> InsertarVentaChofer(Venta venta);
        Task<IEnumerable<Venta>> ObtenerVentas(DateTime fecha1, DateTime fecha2);
        Task<bool> Actualizar(Venta venta);
        Task<Venta> VentaViaje(int idV);
        Task<bool> Eliminar(int id, double valor);
        Task<Venta> ObtenerVentaComprador(int idComprador);
        Task<bool> Denegar(int id);
    }
}
