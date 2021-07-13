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
    public class RepositorioCombi: IRepositorioCombi
    {
        private SqlConfiguration _ConnectionString;

        public RepositorioCombi(SqlConfiguration connectionString)
        {
            _ConnectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_ConnectionString.ConnectionString);
        }
        public async Task<bool> Actualizar(Combi combi)
        {
            var db = dbConnection();

            var sql = "UPDATE Combi SET idChofer=@IdChofer, patente=@Patente, modelo=@Modelo, asientos=@Asientos, superComoda=@SuperComoda WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { combi.IdChofer, combi.Patente, combi.Modelo, combi.Asientos, combi.SuperComoda, combi.Id});
            return result > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var db = dbConnection();

            var sql = "DELETE Combi WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id = id });
            return result > 0;
        }

        public async Task<bool> Insertar(Combi combi)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Combi (idChofer, patente, modelo, asientos, superComoda) 
                        VALUES(@IdChofer, @Patente, @Modelo, @Asientos, @SuperComoda)";
            var result = await db.ExecuteAsync(sql, new { combi.IdChofer, combi.Patente, combi.Modelo, combi.Asientos, combi.SuperComoda });

            return result > 0;
        }

        public async Task<Combi> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Combi WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Combi>(sql, new { Id = id });
        }
        public async Task<IEnumerable<Combi>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Combi";
            return await db.QueryAsync<Combi>(sql, new { });
        }

        public async Task<Combi> ObtenerCombiRuta(int idRuta)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Combi c WHERE EXISTS(SELECT * FROM Ruta WHERE idCombi=c.Id and Id=@IdRuta)";
            return await db.QueryFirstOrDefaultAsync<Combi>(sql, new { IdRuta = idRuta });
        }
    }
}
