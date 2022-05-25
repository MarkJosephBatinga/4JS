using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Shared;

namespace _4JS.Client.Services.LoginService
{
    interface ILoginService
    {
        Task<User> GetUser(string email);

        Task<User> LoginUser(LoginToken LoginUser);

        Task<Admin> GetAdmin(string email);

        Task<Admin> LoginAdmin(LoginToken LoginAdmin);
    }
}
