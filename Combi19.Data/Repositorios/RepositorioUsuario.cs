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
    public class RepositorioUsuario: IRepositorioUsuario
    {
        private SqlConfiguration _connectionString;

        public RepositorioUsuario(SqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_connectionString.ConnectionString);
        }
        public async Task<bool> Actualizar(AspNetUsersDto usuario)
        {
            var db = dbConnection();

            var sql = @"UPDATE AspNetUsers 
                    SET nombre=@Nombre, apellido=@Apellido, dni=@Dni, email=@Email, 
                        fechaNacimiento=@FechaNacimiento, planPremium=@PlanPremium, CodigoSeguridad=@CodigoSeguridad, 
                        NombreTarjeta=@NombreTarjeta, Vencimiento=@Vencimiento, NumeroTarjeta=@NumeroTarjeta, fechaSintoma=@FechaSintoma
                    WHERE idAux=@IdAux";

            var result = await db.ExecuteAsync(sql, new {
                usuario.Nombre,
                usuario.Apellido,
                usuario.Dni,
                usuario.Email,
                usuario.Clave,
                usuario.FechaNacimiento,
                usuario.PlanPremium,
                usuario.CodigoSeguridad,
                usuario.NombreTarjeta,
                usuario.NumeroTarjeta,
                usuario.Vencimiento,
                usuario.FechaSintoma,
                usuario.IdAux }); ;
            return result > 0;
        }

        public async Task<bool> Eliminar(int id)
        {
            var db = dbConnection();

            var sql = "DELETE AspNetUsers WHERE idAux=@IdAux";

            var result = await db.ExecuteAsync(sql, new { IdAux = id });
            return result > 0;
        }

        public async Task<bool> Insertar(AspNetUsersDto usuario)
        {
            var db = dbConnection();

            var sql = @"INSERT INTO AspNetUsers (nombre, apellido, dni, email, clave, fechaNacimiento, planPremium, CodigoSeguridad, NombreTarjeta, NumeroTarjeta, Vencimiento, fechaSintoma ) 
                    VALUES(@Nombre, @Apellido, @Dni, @Email, @Clave, @FechaNacimiento, @PlanPremium, @CodigoSeguridad, @NombreTarjeta, @NumeroTarjeta, @Vencimiento, @FechaSintoma)";
            var result = await db.ExecuteAsync(sql, new 
            { usuario.Nombre, usuario.Apellido, usuario.Dni, usuario.Email, usuario.Clave, usuario.FechaNacimiento, usuario.PlanPremium,
                usuario.CodigoSeguridad, usuario.NombreTarjeta, usuario.NumeroTarjeta, usuario.Vencimiento, usuario.FechaSintoma
            });

            return result > 0;
        }

        public async Task<AspNetUsersDto> Obtener(int id)
        {
            var db = dbConnection();

            var sql = @"SELECT idAux, nombre, apellido, dni, email, fechaNacimiento, planPremium, PhoneNumber, CodigoSeguridad, NombreTarjeta, NumeroTarjeta, Vencimiento, fechaSintoma 
                        FROM AspNetUsers 
                        WHERE idAux=@IdAux";
            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { IdAux = id});
        }
        public async Task<IEnumerable<AspNetUsersDto>> Obtener(DateTime fecha1, DateTime fecha2)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM AspNetUsers vi WHERE " +
                "((datepart(YYYY,vi.FechaSintoma)>=@Año1 and datepart(MM,vi.FechaSintoma)>=@Mes1 and datepart(DD,vi.FechaSintoma)>=@Dia1)" +
                "AND" +
                "(datepart(YYYY,vi.FechaSintoma)<=@Año2 and datepart(MM,vi.FechaSintoma)<=@Mes2 and datepart(DD,vi.FechaSintoma)<=@Dia2))";
            return await db.QueryAsync<AspNetUsersDto>(sql, new
            {
                Año1 = fecha1.Year,
                Mes1 = fecha1.Month,
                Dia1 = fecha1.Day,
                Fecha1 = fecha1,
                Año2 = fecha2.Year,
                Mes2 = fecha2.Month,
                Dia2 = fecha2.Day,
                Fecha2 = fecha2
            });
        }
        public async  Task<Tarjeta> ObtenerTarjeta(int id)
        {
            var db = dbConnection();

            var sql = @"SELECT idAux, nombre, apellido, dni, email, fechaNacimiento, planPremium, CodigoSeguridad, NombreTarjeta, NumeroTarjeta, Vencimiento, fechaSintoma 
                            FROM AspNetUsers 
                            WHERE idAux=@IdAux";
            AspNetUsersDto usuario = await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { IdAux = id });
            Tarjeta tarjeta = new Tarjeta( usuario.NumeroTarjeta, usuario.NombreTarjeta, usuario.Vencimiento);
            return tarjeta;
        }

        public async Task<AspNetUsersDto> Obtener(string email, string contraseña)
        {
            var db = dbConnection();

            var sql = "SELECT nombre, apellido, dni, email, fechaNacimiento, planPremium, fechaSintoma FROM AspNetUsers WHERE email=@Email";
            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { Email = email});
        }

        public async Task<AspNetUsersDto> ExisteEmail(string email)
        {
            var db = dbConnection();

            var sql = "SELECT * FROM AspNetUsers WHERE email=@Email";
            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { Email = email });
        }

        public async Task<IEnumerable<AspNetUsersDto>> ObtenerTodos()
            {
                var db = dbConnection();

                var sql = "SELECT IdAux, nombre, apellido, dni, email, fechaNacimiento, planPremium, fechaSintoma FROM AspNetUsers";
                return await db.QueryAsync<AspNetUsersDto>(sql, new { });
            }

        public async Task<AspNetUsersDto> Obtener(string name)
        {
            var db = dbConnection();

            var sql = @"SELECT idAux, id, nombre, apellido, dni, email, fechaNacimiento, planPremium, fechaSintoma 
                        FROM AspNetUsers 
                        WHERE email=@Name";
            return await db.QueryFirstOrDefaultAsync<AspNetUsersDto>(sql, new { Name = name });
        }
    }
}
