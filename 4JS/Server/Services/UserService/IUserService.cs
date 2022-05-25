using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Shared;

namespace _4JS.Server.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> AddUser(User user);

        Task<User> GetUser(int userId);

        Task<List<User>> UpdateUser(User user);

        Task<List<User>> RemoveUser(User user);

        Task<List<User>> LoadAllUsers();
        Task<List<User>> LoadAllUnvaccinatedUsers();
    }
}
