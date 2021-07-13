using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class Venta
    {
        public Venta()
        {

        }
        public Venta(string estado, int idU, double precioUnitario, DateTime fecha, List<Pasaje> pasajes, bool premium, int idVenta, string numeroT)
        {
            Estado = estado;
            IdUsuario = idU;
            if (premium)
            {
                PrecioTotal =
                    (precioUnitario * pasajes.Count) - ((precioUnitario * pasajes.Count) * 0.1);
            }
            else
            {
                PrecioTotal = precioUnitario * pasajes.Count;
            }
            PrecioUnitario = precioUnitario;
            Fecha = fecha;
            CantidadPasajes = pasajes.Count;
            IdViaje = idVenta;
            NumeroTarjeta = numeroT;
        }

        public Venta(string estado, int idU, double precioUnitario, DateTime fecha, List<Pasaje> pasajes, bool premium, int idVenta)
        {
            Estado = estado;
            IdUsuario = idU;
            if (premium)
            {
                PrecioTotal =
                    (precioUnitario * pasajes.Count) - ((precioUnitario * pasajes.Count) * 0.1);
            }
            else
            {
                PrecioTotal = precioUnitario * pasajes.Count;
            }
            PrecioUnitario = precioUnitario;
            Fecha = fecha;
            CantidadPasajes = pasajes.Count;
            IdViaje = idVenta;
        }

        public int Id { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }
        public double PrecioTotal { get; set; }
        public double PrecioUnitario { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadPasajes { get; set; }
        public int IdViaje { get; set; }
        [Required]
        public string NumeroTarjeta { get; set; }
        public double Reintegro { get; set; }
    }
}
