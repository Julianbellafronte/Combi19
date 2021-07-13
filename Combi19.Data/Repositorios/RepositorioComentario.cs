using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using Combi19.Model;

namespace Combi19.Data.Repositorios
{
    public class RepositorioComentario: IRepositorioComentario
    {
        private SqlConfiguration _connectionString;

        public RepositorioComentario(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> Actualizar(Comentario comentario)
        {
            var db = dbConnection();

            var sql = "UPDATE Comentario SET contenido=@Contenido WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { comentario.Contenido, comentario.Id});
            return result > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var db = dbConnection();

            var sql = "DELETE Comentario WHERE id=@Id";

            var result = await db.ExecuteAsync(sql, new { Id = id });
            return result > 0;
        }

        public async Task<bool> Insertar(Comentario comentario)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO Comentario (contenido, idCreador, fecha, nombreCreador) 
                        VALUES(@Contenido, @IdCreador, @Fecha, @NombreCreador)";
            var result = await db.ExecuteAsync(sql, new { comentario.Contenido, comentario.IdCreador, comentario.Fecha, comentario.NombreCreador });

            return result > 0;
        }

        public async Task<Comentario> Obtener(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Comentario WHERE id=@Id";
            return await db.QueryFirstOrDefaultAsync<Comentario>(sql, new { Id = id });
        }

        public async Task<IEnumerable<Comentario>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Comentario";
            return await db.QueryAsync<Comentario>(sql, new { });
        }

        public async Task<IEnumerable<Comentario>> ObtenerTodosUsuario(int idU)
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM Comentario
                        WHERE IdCreador=@IdU
                        ORDER BY fecha DESC";
            return await db.QueryAsync<Comentario>(sql, new { IdU = idU});
        }

        public async Task<IEnumerable<Comentario>> ObtenerDestacados()
        {
            var db = dbConnection();

            var sql = "SELECT TOP 5 * FROM Comentario c ORDER BY c.fecha DESC";
            return await db.QueryAsync<Comentario>(sql, new { });
        }
    }
}
