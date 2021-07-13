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
    public class RepositorioChofer : IRepositorioChofer
    {
        private SqlConfiguration _connectionString;

        public RepositorioChofer(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> Actualizar(AspNetUsersDto chofer)
        {
            var db = dbConnection();

            var sql = "UPDATE AspNetUsers SET nombre=@Nombre, apellido=@Apellido, dni=@Dni, PhoneNumber=@PhoneNumber, email=@Email WHERE IdAux=@IdAux";

            var result = await db.ExecuteAsync(sql, new {chofer.Nombre, chofer.Apellido, chofer.Dni, chofer.PhoneNumber, chofer.Email,  chofer.IdAux});
            return result > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var db = dbConnection();

            var sql = "DELETE AspNetUsers WHERE idAux=@IdAux";

            var result = await db.ExecuteAsync(sql, new {IdAux=id});
            return result > 0;
        }

        public async Task<bool> Insertar(AspNetUsersDto chofer)
        {
            var db = dbConnection();

            var sql = "INSERT INTO Chofer (nombre, apellido, dni, PhoneNumber, email, clave) VALUES(@Nombre, @Apellido, @Dni, @PhoneNumber, @Email, @Clave)";
            var result = await db.ExecuteAsync(sql, new { chofer.Nombre, chofer.Apellido, chofer.Dni, chofer.PhoneNumber, chofer.Email, chofer.Clave });

            return result > 0;
        }

        public async Task<AspNetUsersDto> Obtener(int id)
        {
            var db = dbConnection();

            var sql = $"SELECT * FROM AspNetUsers WHERE IdAux=@Id";
            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { Id = id});
        }

        public async Task<AspNetUsersDto> Obtener(string email, string contraseña)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM Chofer WHERE email=@Email AND clave=@Clave";
            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { Email=email, Clave=contraseña});
        }

        public async Task<IEnumerable<AspNetUsersDto>> ObtenerTodos()
        {
            var db = dbConnection();

            var sql = $"SELECT * FROM AspNetUsers us WHERE EXISTS" +
                $"(select * from AspNetUserRoles usR where usR.UserId=us.id and exists " +
                $"(select * from AspNetRoles r where  r.Id=usR.RoleId and r.Name='Chofer'))";
            return await db.QueryAsync<AspNetUsersDto>(sql, new{ });
        }

        public async Task<AspNetUsersDto> TieneCombi(int id)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM AspNetUsers a WHERE EXISTS(SELECT * FROM Combi co WHERE(co.idChofer = @IdAux and a.IdAux = @IdAux)) ";

            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { IdAux = id });
        }

        public async Task<AspNetUsersDto> ExisteEmail(string email)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM AspNetUsers WHERE Email = @Email ";

            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { Email = email });
        }

        public async Task<IEnumerable<AspNetUsersDto>> ObtenerTodosSinCombi()
        {
            var db = dbConnection();

            var sql = @"SELECT * FROM AspNetUsers us WHERE EXISTS
                (select * from AspNetUserRoles usR where usR.UserId=us.id and exists 
                (select * from AspNetRoles r where  r.Id=usR.RoleId and r.Name='Chofer' and 
                not exists(select * from Combi where us.IdAux = idChofer)))";
            return await db.QueryAsync<AspNetUsersDto>(sql, new { });
        }

        public async Task<AspNetUsersDto> Obtener(string name)
        {
            var db = dbConnection();

            var sql = @"SELECT *
                        FROM AspNetUsers 
                        WHERE email=@Name";
            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { Name = name });
        }
    }
}
