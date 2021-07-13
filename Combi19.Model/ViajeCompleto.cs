using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Model
{
    public class ViajeCompleto: Viaje
    {
        public ViajeCompleto() 
        {

        }
        public ViajeCompleto
            (int idViaje, string ciudadOrigen, string provinciaOrigen, 
            string ciudadDestino, string provinciaDestino, DateTime fechaSalida,
            double precio, DateTime hsSalida,
            int idRuta, int idCiudadOrigen, int idCiudadDestino, Combi combi, int asientos)
        {
            IdViaje = idViaje;
            IdRuta = idRuta;
            IdCiudadOrigen = idCiudadOrigen;
            CiudadOrigen = ciudadOrigen;
            ProvinciaOrigen = provinciaOrigen;
            IdCiudadDestino = idCiudadDestino;
            CiudadDestino = ciudadDestino;
            ProvinciaDestino = provinciaDestino;
            FechaSalida = fechaSalida;
            Precio = precio;
            HsSalida = hsSalida;
            Combi = combi;
            Asientos = asientos;
        }
        public ViajeCompleto
            (int idViaje, string ciudadOrigen, string provinciaOrigen,
            string ciudadDestino, string provinciaDestino, DateTime fechaSalida,
            double precio, DateTime hsSalida, Combi combi, int asientos)
        {
            IdViaje = idViaje;
            CiudadOrigen = ciudadOrigen;
            ProvinciaOrigen = provinciaOrigen;
            CiudadDestino = ciudadDestino;
            ProvinciaDestino = provinciaDestino;
            FechaSalida = fechaSalida;
            Precio = precio;
            HsSalida = hsSalida;
            Combi = combi;
            Asientos = asientos;
        }
        public ViajeCompleto
            (int idViaje, string ciudadOrigen, string provinciaOrigen,
            string ciudadDestino, string provinciaDestino, DateTime fechaSalida,
            double precio, DateTime hsSalida, int asientos)
        {
            IdViaje = idViaje;
            CiudadOrigen = ciudadOrigen;
            ProvinciaOrigen = provinciaOrigen;
            CiudadDestino = ciudadDestino;
            ProvinciaDestino = provinciaDestino;
            FechaSalida = fechaSalida;
            Precio = precio;
            HsSalida = hsSalida;
            Asientos = asientos;
        }
        public int IdViaje { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe seleccionar una ciudad de origen")]
        public int IdCiudadOrigen { get; set; }
        public string CiudadOrigen { get; set; }
        public string ProvinciaOrigen { get; set; }
        [Required(ErrorMessage = "Por favor complete este campo")]
        [Range(1, int.MaxValue, ErrorMessage = "Se debe seleccionar una ciudad de destino")]
        public int IdCiudadDestino { get; set; }
        public string CiudadDestino { get; set; }
        public string ProvinciaDestino { get; set; }
        public DateTime HsSalida { get; set; }
        public Combi Combi { get; set; }

    }
}
