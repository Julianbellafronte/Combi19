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
    public class RepositorioViaje : IRepositorioViaje
    {
        private SqlConfiguration _connectionString;

        public RepositorioViaje(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> Actualizar(Viaje viaje)
        {
            var db = dbConnection();

            var sql = "UPDATE Viaje SET idRuta=@IdRuta, fechaSalida=@FechaSalida, precio=@Precio, asientos=@Asientos, estado=@Estado WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { viaje.IdRuta, viaje.FechaSalida, viaje.Precio, viaje.Id, viaje.Asientos, viaje.Estado });
            return result > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var db = dbConnection();

            var sql = "DELETE FROM Viaje WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id = id });
            return result > 0;
        }

        public async Task<bool> Insertar(Viaje viaje)
        {
            var db = dbConnection();

            var sql = "INSERT INTO Viaje (idRuta, fechaSalida, precio, asientos, estado) VALUES(@IdRuta, @FechaSalida, @Precio, @Asientos, @Estado)";
            var result = await db.ExecuteAsync(sql, new { viaje.IdRuta, viaje.FechaSalida, viaje.Precio, viaje.Asientos, viaje.Estado });

            return result > 0;
        }

        public async Task<Viaje> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Viaje WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Viaje>(sql, new { Id = id });
        }

        public async Task<Viaje> Obtener(int idR, DateTime fecha)
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM Viaje 
                        WHERE idRuta=@Id and fechaSalida=@Fecha";
            return await db.QueryFirstOrDefaultAsync<Viaje>(sql, new { Id = idR, Fecha = fecha }); ;
        }
        public async Task<IEnumerable<Viaje>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Viaje";
            return await db.QueryAsync<Viaje>(sql, new { });
        }

        public async Task<IEnumerable<Viaje>> ViajesProximos(DateTime fecha)
        {
            var db = dbConnection();

            var sql = @"SELECT vi.Id, vi.IdRuta, vi.FechaSalida, vi.Precio FROM Viaje vi 
                                 INNER JOIN Ruta r ON (vi.IdRuta = r.Id)
                                 INNER JOIN Combi c ON (r.IdCombi = c.Id)
                                 INNER JOIN AspNetUsers ch ON(ch.IdAux=c.IdChofer)
                                 WHERE (datepart(YYYY,vi.FechaSalida)>=@Año and datepart(MM,vi.FechaSalida)>=@Mes and datepart(DD,vi.FechaSalida)>=@Dia)";
            return await db.QueryAsync<Viaje>(sql, new { Año = fecha.Year, Mes = fecha.Month, Dia = fecha.Day });
        }

        public async Task<Viaje> ViajeEnFecha(int idC, DateTime fecha)
        {
            var db = dbConnection();

            var sql = @"SELECT vi.Id, vi.IdRuta, vi.FechaSalida, vi.Precio FROM Viaje vi 
                                 INNER JOIN Ruta r ON (vi.IdRuta = r.Id)
                                 INNER JOIN Combi c ON (r.IdCombi = c.Id)
                                 INNER JOIN AspNetUsers ch ON(ch.IdAux=c.IdChofer)
                                 WHERE (ch.IdAux=@IdC and datepart(YYYY,vi.FechaSalida)=@Año and datepart(MM,vi.FechaSalida)=@Mes and datepart(DD,vi.FechaSalida)=@Dia)";
            return await db.QueryFirstOrDefaultAsync<Viaje>(sql, new { IdC = idC, Año = fecha.Year, Mes = fecha.Month, Dia = fecha.Day });
        }

        public async Task<IEnumerable<Viaje>> ObtenerViajes(int idR, DateTime fecha)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Viaje vi WHERE (vi.idRuta=@IdR and (datepart(YYYY,vi.fechaSalida)=@Año and datepart(MM,vi.fechaSalida)=@Mes and datepart(DD,vi.fechaSalida)=@Dia))";
            return await db.QueryAsync<Viaje>(sql, new { IdR = idR, Año = fecha.Year, Mes = fecha.Month, Dia = fecha.Day, Fecha = fecha });
        }

        public async Task<IEnumerable<Viaje>> ObtenerViajes(DateTime fecha1, DateTime fecha2)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Viaje vi WHERE " +
                "((datepart(YYYY,vi.fechaSalida)>=@Año1 and datepart(MM,vi.fechaSalida)>=@Mes1 and datepart(DD,vi.fechaSalida)>=@Dia1)" +
                "AND" +
                "(datepart(YYYY,vi.fechaSalida)<=@Año2 and datepart(MM,vi.fechaSalida)<=@Mes2 and datepart(DD,vi.fechaSalida)<=@Dia2))";
            return await db.QueryAsync<Viaje>(sql, new {
                Año1 = fecha1.Year, Mes1 = fecha1.Month, Dia1 = fecha1.Day, Fecha1 = fecha1,
                Año2 = fecha2.Year, Mes2 = fecha2.Month, Dia2 = fecha2.Day, Fecha2 = fecha2
            });
        }

        public async Task<IEnumerable<Viaje>> ViajesChofer(int idChofer)
            {
            var db = dbConnection();

            var sql = @"SELECT v.id, v.idRuta, v.fechaSalida, v.precio, v.asientos, v.estado
                FROM Viaje v INNER JOIN Ruta r ON(v.idRuta=r.id)
                INNER JOIN Combi c ON(c.id=r.idCombi)
                WHERE(c.idChofer=@IdChofer AND v.Estado='Finalizado')
                ORDER BY v.fechaSalida ASC";
            return await db.QueryAsync<Viaje>(sql, new {IdChofer=idChofer});
        }

        public async Task<IEnumerable<Viaje>> ViajesProximosChofer(int idChofer)
        {
            var db = dbConnection();

            var sql = @"SELECT v.id, v.idRuta, v.fechaSalida, v.precio, v.asientos, v.estado
                FROM Viaje v INNER JOIN Ruta r ON(v.idRuta=r.id)
                INNER JOIN Combi c ON(c.id=r.idCombi)
                WHERE(c.idChofer=@IdChofer AND v.Estado='Pendiente' And datepart(YYYY,v.FechaSalida)>=@Año and datepart(MM,v.FechaSalida)>=@Mes and datepart(DD,v.FechaSalida)>=@Dia and datepart(HH, r.hsSalida)>=@Hora)
                ORDER BY v.fechaSalida ASC";
            return await db.QueryAsync<Viaje>(sql, new { IdChofer = idChofer, Año = DateTime.Today.Year, Mes = DateTime.Today.Month, Dia = DateTime.Today.Day, Hora = DateTime.Now.Hour, Minutos = DateTime.Now.Minute});
        }

        public async Task<Viaje> ViajeEnCurso(int idChofer)
        {
            var db = dbConnection();

            var sql = @"SELECT v.id, v.idRuta, v.fechaSalida, v.precio, v.asientos, v.estado
                FROM Viaje v INNER JOIN Ruta r ON(v.idRuta=r.id)
                INNER JOIN Combi c ON(c.id=r.idCombi)
                WHERE(c.idChofer=@IdChofer AND v.Estado='En Curso')"; 
            return await db.QueryFirstOrDefaultAsync<Viaje>(sql, new { IdChofer = idChofer});
        }

        
    }
}
