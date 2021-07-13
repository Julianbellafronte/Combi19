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
    public class RepositorioProvincia : IRepositorioProvincia
    {
        private SqlConfiguration _connectionString;

        public RepositorioProvincia(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public async Task<Provincia> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Provincia WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Provincia>(sql, new { Id = id });
        }
            public async Task<IEnumerable<Provincia>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Provincia";
            return await db.QueryAsync<Provincia>(sql, new { });
        }
    }
}
