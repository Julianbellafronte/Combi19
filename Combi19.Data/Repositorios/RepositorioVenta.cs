using Combi19.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi19.Data.Repositorios
{
    public class RepositorioVenta : IRepositorioVenta
    {
        private SqlConfiguration _connectionString;

        public RepositorioVenta(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> Eliminar(int id, double valor)
        {
            var db = dbConnection();

            var sql = @"UPDATE Venta SET Estado='Cancelado', reintegro=@Valor 
                      WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id=id, Valor=valor });
            return result > 0;
        }

        public async Task<bool> Denegar(int id)
        {
            var db = dbConnection();

            var sql = @"UPDATE Venta SET Estado='Ausente', reintegro=@Valor 
                      WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id = id, Valor = 0 }) ;
            return result > 0;
        }

        public async Task<IEnumerable<Venta>> ObtenerVentas(DateTime fecha1, DateTime fecha2)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Venta vi WHERE " +
                "((datepart(YYYY,vi.fecha)>=@Año1 and datepart(MM,vi.fecha)>=@Mes1 and datepart(DD,vi.fecha)>=@Dia1)" +
                "AND" +
                "(datepart(YYYY,vi.fecha)<=@Año2 and datepart(MM,vi.fecha)<=@Mes2 and datepart(DD,vi.fecha)<=@Dia2))";
            return await db.QueryAsync<Venta>(sql, new
            {
                Año1 = fecha1.Year,
                Mes1 = fecha1.Month,
                Dia1 = fecha1.Day,
                Fecha1 = fecha1,
                Año2 = fecha2.Year,
                Mes2 = fecha2.Month,
                Dia2 = fecha2.Day,
                Fecha2 = fecha2
            });
        }

        public async Task<bool> Actualizar(Venta venta)
        {
            var db = dbConnection();

            var sql = @"UPDATE Venta SET precioTotal=@PrecioTotal, estado=@Estado
                      WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { venta.PrecioTotal, venta.Estado, venta.Id });
            return result > 0;
        }

        public async Task<Row> Insertar(Venta venta)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Venta (estado, idUsuario, precioTotal, precioUnitario, fecha, cantidadPasajes, idViaje, numeroTarjeta,reintegro) 
                        VALUES(@Estado, @IdUsuario, @PrecioTotal, @PrecioUnitario, @Fecha, @CantidadPasajes, @IdViaje, @NumeroTarjeta, @Reintegro)
                        SELECT SCOPE_IDENTITY() AS ident";
            
            return await db.QueryFirstOrDefaultAsync<Row>(sql, new { venta.Estado, venta.IdUsuario, venta.PrecioTotal, venta.PrecioUnitario, venta.Fecha, venta.CantidadPasajes, venta.IdViaje, venta.NumeroTarjeta, venta.Reintegro});         
        }
        public async Task<Row> InsertarVentaChofer(Venta venta)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Venta (estado, idUsuario, precioTotal, precioUnitario, fecha, cantidadPasajes, idViaje) 
                        VALUES(@Estado, @IdUsuario, @PrecioTotal, @PrecioUnitario, @Fecha, @CantidadPasajes, @IdViaje)
                        SELECT SCOPE_IDENTITY() AS ident";

            return await db.QueryFirstOrDefaultAsync<Row>(sql, new { venta.Estado, venta.IdUsuario, venta.PrecioTotal, venta.PrecioUnitario, venta.Fecha, venta.CantidadPasajes, venta.IdViaje});
        }
        public async Task<Venta> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Venta WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Venta>(sql, new { Id = id });
        }
        public async Task<IEnumerable<Venta>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = @" SELECT * 
                         FROM Venta ";

            return await db.QueryAsync<Venta>(sql, new { });
        }

        public async Task<IEnumerable<Venta>> ObtenerTodos(int idUser)
        {
            var db = dbConnection();

            var sql = @" SELECT * 
                         FROM Venta 
                         WHERE idUsuario=@IdUser
                         ORDER BY fecha asc";

            return await db.QueryAsync<Venta>(sql, new {IdUser=idUser});
        }

        public async Task<Venta> VentaViaje(int idV)
        {
            var db = dbConnection();

            var sql = @" SELECT * 
                         FROM Venta 
                         WHERE idViaje=@IdV";

            return await db.QueryFirstOrDefaultAsync<Venta>(sql, new { IdV = idV });
        }
        public async Task<Venta> ObtenerVentaComprador(int idComprador)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Venta WHERE idUsuario=@Id";
            return await db.QueryFirstOrDefaultAsync<Venta>(sql, new { Id = idComprador });
        }
    }
}
