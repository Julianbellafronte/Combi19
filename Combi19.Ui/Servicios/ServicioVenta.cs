using Combi19.Data;
using Combi19.Model;
using Combi19.Ui.Interfaces;
using System;
using System.Collections.Generic;
using Combi19.Data.Repositorios;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui.Servicios
{
    public class ServicioVenta : IServicioVenta
    {
        private readonly SqlConfiguration _configuration;
        private IRepositorioVenta _RepositorioVenta;

        public ServicioVenta(SqlConfiguration configuration)
        {
            _configuration = configuration;
            _RepositorioVenta = new RepositorioVenta(configuration);
        }

        public Task Eliminar(int id, double valor)
        {
            return _RepositorioVenta.Eliminar(id, valor); 
        }

        public Task<Row> Guardar(Venta venta)
        {
            if(venta.NumeroTarjeta != null)
            {
                return _RepositorioVenta.Insertar(venta);
            }
            else
            {
                return _RepositorioVenta.InsertarVentaChofer(venta);
            }
            
        }
        
        public Task<bool> Actualizar(Venta venta)
        {
            return _RepositorioVenta.Actualizar(venta);
        }
        public Task<Venta> VentaViaje(int idV)
        {
            return _RepositorioVenta.VentaViaje(idV);
        }



    public Task<Venta> Obtener(int id)
        {
            return _RepositorioVenta.Obtener(id);
        }

        public Task<IEnumerable<Venta>> ObtenerTodos(int idUser)
        {
            return _RepositorioVenta.ObtenerTodos(idUser);
        }
        public Task<IEnumerable<Venta>> ObtenerTodos()
        {
            return _RepositorioVenta.ObtenerTodos();
        }

        public Task<IEnumerable<Venta>> ObtenerVentas(DateTime fecha1, DateTime fecha2)
        {
            return _RepositorioVenta.ObtenerVentas(fecha1, fecha2);
        }

        public Task<Venta> ObtenerVentaComprador(int idComprador)
        {
            return _RepositorioVenta.ObtenerVentaComprador(idComprador);
        }

        public Task<bool> Denegar(int id)
        {
            return _RepositorioVenta.Denegar(id);
        }
    }
}
