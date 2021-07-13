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
    public class RepositorioRuta : IRepositorioRuta
    {
        private SqlConfiguration _connectionString;

        public RepositorioRuta(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> Actualizar(Ruta ruta)
        {
            var db = dbConnection();

            var sql = "UPDATE Ruta SET idCiudad1=@IdCiudad1, idCiudad2=@IdCiudad2, km=@Km, hsSalida=@HsSalida, idCombi=@IdCombi WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { ruta.IdCiudad1, ruta.IdCiudad2, ruta.Km, ruta.HsSalida, ruta.IdCombi, ruta.Id });
            return result > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var db = dbConnection();

            var sql = "DELETE Ruta WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id = id });
            return result > 0;
        }

        public async Task<bool> Insertar(Ruta ruta)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Ruta (idCiudad1, idCiudad2, km, hsSalida, idCombi) 
                        VALUES(@IdCiudad1, @IdCiudad2, @Km, @HsSalida, @IdCombi)";
            var result = await db.ExecuteAsync(sql, new { ruta.IdCiudad1, ruta.IdCiudad2, ruta.Km, ruta.HsSalida, ruta.IdCombi });

            return result > 0;
        }

        public async Task<Ruta> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Ruta WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Ruta>(sql, new { Id = id });
        }
        public async Task<IEnumerable<Ruta>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = @" SELECT * 
                         FROM Ruta ";

            return await db.QueryAsync<Ruta>(sql, new { });
        }
        public async Task<Ruta> Obtener(int idC1, int idC2, DateTime hsSalida, int idCom)
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM  Ruta r 
                        WHERE (r.idCiudad1 = @IdC1 and r.idCiudad2 = @IdC2 and datepart(HH,r.hsSalida)=@Hora and datepart(MINUTE,r.hsSalida)=@Minutos and idCombi=@IdCom)";

            return await db.QueryFirstOrDefaultAsync<Ruta>(sql, new {IdC1=idC1, Idc2=idC2, Hora=hsSalida.Hour, Minutos=hsSalida.Minute, IdCom=idCom});
        }
        public async Task<IEnumerable<Ruta>> Obtener(int idC1, int idC2)
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM  Ruta r 
                        WHERE r.idCiudad1 = @IdC1 and r.idCiudad2 = @IdC2";

            return await db.QueryAsync<Ruta>(sql, new { IdC1 = idC1, IdC2 = idC2});
        }
        public async Task<IEnumerable<Ruta>> ObtenerTodas(int idC1, int idC2)
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM  Ruta r 
                        WHERE r.idCiudad1 = @IdC1 and r.idCiudad2 = @IdC2";

            return await db.QueryAsync<Ruta>(sql, new { IdC1 = idC1, IdC2 = idC2 });
        }

        public async Task<Ciudad> ObtenerCiudad(int idCiudad)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Ciudad WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Ciudad>(sql, new { Id = idCiudad });
        }

        Task<Ruta> IRepositorioRuta.Obtener(int idC1, int idC2)
        {
            throw new NotImplementedException();
        }
    }
}
