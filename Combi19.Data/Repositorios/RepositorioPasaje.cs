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
    public class RepositorioPasaje : IRepositorioPasaje
    {
        private SqlConfiguration _connectionString;

        public RepositorioPasaje(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> Insertar(Pasaje pasaje)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Pasaje (nombre, apellido, estado, idVenta, dni, idViaje) 
                        VALUES(@Nombre, @Apellido, @Estado, @IdVenta, @Dni, @IdViaje)";
            var result = await db.ExecuteAsync(sql, new { pasaje.Nombre, pasaje.Apellido, pasaje.Estado, pasaje.IdVenta, pasaje.Dni, pasaje.IdViaje });

            return result > 0;
        }

        public async Task<Pasaje> Obtener(string dni, int idViaje)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Pasaje WHERE dni=@Dni and idViaje=@IdViaje";
            return await db.QueryFirstOrDefaultAsync<Pasaje>(sql, new { Dni = dni, IdViaje = idViaje });
        }
        public async Task<Pasaje> ObtenerPasaje(int idPasaje)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Pasaje WHERE id=@IdPasaje";
            return await db.QueryFirstOrDefaultAsync<Pasaje>(sql, new { IdPasaje = idPasaje });
        }
        public async Task<IEnumerable<Pasaje>> ObtenerTodos(int idVenta)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Pasaje WHERE idVenta=@IdVenta";
            return await db.QueryAsync<Pasaje>(sql, new { IdVenta = idVenta });
        }
        public async Task<IEnumerable<Pasaje>> ObtenerTodosViajes(int idViaje)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Pasaje WHERE idViaje=@IdViaje";
            return await db.QueryAsync<Pasaje>(sql, new { IdViaje = idViaje });
        }
        public async Task<IEnumerable<Pasaje>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = @" SELECT * 
                         FROM Pasaje ";

            return await db.QueryAsync<Pasaje>(sql, new { });
        }

        public async Task<bool> CancelarPasaje(Pasaje pasaje)
        {
            var db = dbConnection();

            var sql = "UPDATE Pasaje SET estado='Cancelado' WHERE idVenta=@IdVenta";

            var result = await db.ExecuteAsync(sql, new { IdVenta = pasaje.IdVenta });
            return result > 0;
        }

        public async Task<bool> Confirmar(int id)
        {
            var db = dbConnection();

            var sql = "UPDATE Pasaje SET estado='Confirmado' WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id =id });
            return result > 0;
        }

        public async Task<bool> PasajeAusente(Pasaje pasaje)
        {
            var db = dbConnection();

            var sql = @"UPDATE Pasaje 
                        SET estado='Ausente' 
                        WHERE (idVenta=@IdVenta and dni=@Dni)";

            var result = await db.ExecuteAsync(sql, new { IdVenta = pasaje.IdVenta, pasaje.Dni });
            return result > 0;
        }

        public async Task<Pasaje> ObtenerPendiente(int id)
        {
            var db = dbConnection();

            var sql = @"SELECT *
                FROM Pasaje
                WHERE(estado='Pendiente' AND idViaje=@Id)";
            return await db.QueryFirstOrDefaultAsync<Pasaje>(sql, new { Id= id });
        }

    }
}
