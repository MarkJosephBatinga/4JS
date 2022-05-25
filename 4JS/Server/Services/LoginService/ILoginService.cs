using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Shared;

namespace _4JS.Server.Services.LoginService
{
    public interface ILoginService
    {

        Task<User> LoginUser(LoginToken LoginUser);

        Task<User> GetUser(string email);

        Task<Admin> LoginAdmin(LoginToken LoginUser);

        Task<Admin> GetAdmin(string email);

    }
}
