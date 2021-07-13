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
   public class RepositorioTesteo: IRepositorioTesteo 
    {
        private SqlConfiguration _ConnectionString;

        public RepositorioTesteo(SqlConfiguration connectionString)
        {
            _ConnectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_ConnectionString.ConnectionString);
        }

        public async Task<bool> Insertar(Testeo testeo)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Testeo (temperatura, tos, idPasaje, gusto, olfato, dolorGarganta, declaracion) 
                        VALUES(@Temperatura, @Tos, @IdPasaje, @Gusto, @Olfato, @DolorGarganta, @Declaracion)";
            var result = await db.ExecuteAsync(sql, new { testeo.Temperatura, testeo.Tos, testeo.IdPasaje, testeo.Gusto, testeo.Olfato, testeo.DolorGarganta, testeo.Declaracion });

            return result > 0;
        }

        public async Task<Testeo> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Testeo WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Testeo>(sql, new { Id = id });
        }
        public async Task<IEnumerable<Testeo>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Testeo";
            return await db.QueryAsync<Testeo>(sql, new { });
        }
    }
}
