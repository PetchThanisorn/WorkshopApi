using Dapper;
using Microsoft.Data.Sqlite;
using ReactAspWorkShop.BackEnd.Model.Request;
using ReactAspWorkShop.BackEnd.View.Infrastructure;

namespace ReactAspWorkShop.BackEnd.View.Services
{
    public class ManagedUserService : IManagedUserService
    {
        public readonly IConfiguration _configuration;

        public ManagedUserService(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public async Task<bool> InsertManageUser(InsertManagedUserRequest request)
        {
            using var connection = new SqliteConnection(_configuration["Test"]);
            try 
            {
                string QuertInsert = @" INSERT INTO STUDENT 
                                            ( FirstName , LastName , Email , Password , BirthDay)
                                    VALUES  (  @FIRSTNAME , @LASTNAME ,@EMAIL, @PASSWORD , @BIRTHDATE ) ";
                await connection.ExecuteAsync(QuertInsert, new
                {
                    FIRSTNAME = request.FirstName,
                    LASTNAME = request.LastName,
                    EMAIL = request.Email,
                    PASSWORD = request.Password,
                    BIRTHDATE = request.Birthday
                });
                return true;
            }
            catch (Exception ex) { throw; }
            finally { connection.Close(); }
        }
    }
}
