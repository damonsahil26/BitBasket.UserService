using BitBasket.Core.Entities;
using BitBasket.Core.RepositoryContracts;
using BitBasket.Infrastructure.DbContext;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperDbContext _dbContext;

        public UserRepository(DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            user.UserId = Guid.NewGuid();
            var query = "INSERT INTO public.\"Users\" (\"UserId\",\"Email\",\"Password\",\"Gender\",\"PersonName\")" +
                " VALUES (@UserId,@Email,@Password,@Gender,@PersonName)";

            var rowsAffected = await _dbContext.DbConnection.ExecuteAsync(query, user);

            if (rowsAffected > 0)
            {
                return user;
            }
            else
            return null;
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
        {
            var query = "SELECT \"UserId\",\"Email\",\"Gender\",\"PersonName\" FROM public.\"Users\"" +
                " WHERE \"Email\" = @Email AND \"Password\" = @Password";

            var parameters = new { Email = email, Password = password};

            var usersFromDb = await _dbContext.DbConnection.QueryFirstOrDefaultAsync<ApplicationUser>(query, parameters);

            return usersFromDb;
        }
    }
}
