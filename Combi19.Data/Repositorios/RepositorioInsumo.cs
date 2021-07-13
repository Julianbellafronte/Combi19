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
    public class RepositorioInsumo: IRepositorioInsumo
    {
        private SqlConfiguration _connectionString;

        public RepositorioInsumo(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> Actualizar(Insumo insumo)
        {
            var db = dbConnection();

            var sql = "UPDATE Insumo SET nombre=@Nombre, codigo=@Codigo, descripcion=@Descripcion, precio=@Precio WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { insumo.Nombre, insumo.Codigo, insumo.Descripcion, insumo.Precio, insumo.Id });
            return result > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var db = dbConnection();

            var sql = "DELETE Insumo WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id = id });
            return result > 0;
        }

        public async Task<bool> Insertar(Insumo insumo)
        {
            var db = dbConnection();

            var sql = "INSERT INTO Insumo (nombre, codigo, descripcion, precio) VALUES(@Nombre, @Codigo, @Descripcion, @Precio)";
            var result = await db.ExecuteAsync(sql, new { insumo.Nombre, insumo.Codigo, insumo.Descripcion, insumo.Precio, insumo.Id});

            return result > 0;
        }

        public async Task<Insumo> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Insumo WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Insumo>(sql, new { Id = id });
        }

        public async Task<IEnumerable<Insumo>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Insumo";
            return await db.QueryAsync<Insumo>(sql, new { });
        }

        public async Task<Insumo> Existe(string cod)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Insumo i WHERE i.codigo = @Codigo";
            return await db.QueryFirstOrDefaultAsync<Insumo>(sql, new { Codigo = cod });
        }
    }
}
