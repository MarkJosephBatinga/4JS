using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Server.Data;
using _4JS.Shared;

namespace _4JS.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _data;

        public UserService(DataContext data)
        {
            _data = data;
        }

        List<User> Users = new List<User>();
        User user = new User();

        public async Task<List<User>> AddUser(User user)
        {
            await _data.user_info.AddAsync(user);
            await _data.SaveChangesAsync();
            return Users = await _data.user_info.ToListAsync();
        }

        public async Task<User> GetUser(int userId)
        {
            return user = await _data.user_info.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }

        public async Task<List<User>> LoadAllUsers()
        {
            Users = await _data.user_info.ToListAsync();
            if (Users == null)
            {
                return Users = new List<User>();
            }
            else
            {
                return Users;
            }
        }

        public async Task<List<User>> RemoveUser(User user)
        {
            _data.user_info.Remove(user);
            await _data.SaveChangesAsync();
            Users = await _data.user_info.ToListAsync();
            return Users;
        }

        public async Task<List<User>> UpdateUser(User user)
        {
            Users = await _data.user_info.ToListAsync();
            var dbUser = await _data.user_info.FindAsync(user.Id);
            if (dbUser != null)
            {
                _data.Entry(dbUser).CurrentValues.SetValues(user);
                await _data.SaveChangesAsync();
            }
            return Users;
        }

        public async Task<List<User>> LoadAllUnvaccinatedUsers()
        {
            var result = await _data.user_info.ToListAsync();
            if (Users == null)
            {
                return Users = new List<User>();
            }
            else
            {
                return Users;
            }
        }
    }
}
