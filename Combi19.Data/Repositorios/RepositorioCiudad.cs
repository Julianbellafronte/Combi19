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
    public class RepositorioCiudad: IRepositorioCiudad
    {
        private SqlConfiguration _connectionString;

        public RepositorioCiudad(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> Actualizar(Ciudad ciudad)
        {
            var db = dbConnection();

            var sql = "UPDATE Ciudad SET nombre=@Nombre, idProvincia= @IdProvincia, codigoPostal=@CodigoPostal WHERE id=@Id";


            var result = await db.ExecuteAsync(sql, new { ciudad.Nombre, ciudad.IdProvincia, ciudad.CodigoPostal, ciudad.Id });
            return result > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var db = dbConnection();

            var sql = "DELETE Ciudad WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id = id });
            return result > 0;
        }

        public async Task<bool> Insertar(Ciudad ciudad)
        {
            var db = dbConnection();

            var sql = "INSERT INTO Ciudad (nombre, idProvincia, codigoPostal) VALUES(@Nombre, @IdProvincia, @CodigoPostal)";
            var result = await db.ExecuteAsync(sql, new {ciudad.Nombre, ciudad.IdProvincia, ciudad.CodigoPostal });

            return result > 0;
        }

        public async Task<Ciudad> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Ciudad WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Ciudad>(sql, new { Id = id });
        }
        public async Task<Ciudad> Obtener(string nombre)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Ciudad WHERE Nombre=@Nombre";
            return await db.QueryFirstOrDefaultAsync<Ciudad>(sql, new { Nombre = nombre });
        }

        public async Task<IEnumerable<Ciudad>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Ciudad";
            return await db.QueryAsync<Ciudad>(sql, new { });
        }
        public async Task<Provincia> ObtenerProvincia(int idProvincia)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Provincia WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Provincia>(sql, new { Id = idProvincia });
        }
        public async Task<bool> CancelarPasaje(Pasaje pasaje)
        {
            var db = dbConnection();

            var sql = "UPDATE Pasaje SET estado='Cancelado' WHERE idVenta=@IdVenta";


            var result = await db.ExecuteAsync(sql, new { pasaje.IdVenta });
            return result > 0;
        }
    }
}
