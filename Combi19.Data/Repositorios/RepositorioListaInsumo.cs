using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combi19.Model;
using Dapper;

namespace Combi19.Data.Repositorios
{
   public  class RepositorioListaInsumo: IRepositorioListaInsumo
    {
        private SqlConfiguration _connectionString;

        public RepositorioListaInsumo(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }

        public async Task<bool> Insertar(ListaInsumo lista)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO ListaInsumo (idVenta, idInsumo) 
                        VALUES(@IdVenta, @IdInsumo)";
            var result = await db.ExecuteAsync(sql, new { lista.IdVenta, lista.IdInsumo});

            return result > 0;
        }
        public async Task<IEnumerable<Insumo>> ObtenerTodos(int idVenta)
        {
            var db = dbConnection();

            var sql = @"SELECT i.id, i.nombre, i.descripcion, i.precio, i.codigo, COUNT(*) as cantidad
                        FROM Insumo i INNER JOIN ListaInsumo l ON(i.id = l.idInsumo)
                        WHERE l.idVenta =@IdVenta
                        GROUP BY i.id, i.nombre, i.descripcion, i.precio, i.codigo";
            return await db.QueryAsync<Insumo>(sql, new { IdVenta = idVenta });
        }

    }
}
