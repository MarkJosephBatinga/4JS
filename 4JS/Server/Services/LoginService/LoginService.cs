using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Server.Data;
using _4JS.Shared;

namespace _4JS.Server.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly DataContext _data;

        public LoginService(DataContext data)
        {
            _data = data;
        }

        User user = new User();
        Admin admin = new Admin();
        public async Task<User> GetUser(string email)
        {
            return user = await _data.user_info.Where(u => u.email == email).FirstOrDefaultAsync();
        }

        public async Task<User> LoginUser(LoginToken LoginUser)
        {
            user = await _data.user_info.Where(u => u.email == LoginUser.email
            && u.password == LoginUser.password).FirstOrDefaultAsync();
            if (user == null)
            {
                return user = new User();
            }
            else
            {
                return user;
            }
        }

        public async Task<Admin> LoginAdmin(LoginToken LoginUser)
        {
            admin = await _data.admin_info.Where(a => a.email == LoginUser.email
            && a.password == LoginUser.password).FirstOrDefaultAsync();
            if (admin == null)
            {
                return admin = new Admin();
            }
            else
            {
                return admin;
            }
        }

        public async Task<Admin> GetAdmin(string email)
        {
            return admin = await _data.admin_info.Where(a => a.email == email).FirstOrDefaultAsync();
        }
    }
}
