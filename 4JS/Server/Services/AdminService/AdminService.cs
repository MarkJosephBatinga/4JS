using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Server.Data;
using _4JS.Shared;

namespace _4JS.Server.Services.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly DataContext _data;

        public AdminService(DataContext data)
        {
            _data = data;
        }

        List<Admin> Admins = new List<Admin>();
        Admin admin = new Admin();

        public async Task<List<Admin>> AddAdmin(Admin admin)
        {
            await _data.admin_info.AddAsync(admin);
            await _data.SaveChangesAsync();
            return Admins = await _data.admin_info.ToListAsync();
        }

        public async Task<Admin> GetAdmin(int adminId)
        {
            return admin = await _data.admin_info.Where(a => a.Id == adminId).FirstOrDefaultAsync();
        }

        public async Task<List<Admin>> LoadAllAdmins()
        {
            return Admins = await _data.admin_info.ToListAsync();
        }

        public async Task<List<Admin>> RemoveAdmin(Admin admin)
        {
            _data.admin_info.Remove(admin);
            await _data.SaveChangesAsync();
            Admins = await _data.admin_info.ToListAsync();
            return Admins;
        }

        public async Task<List<Admin>> UpdateAdmin(Admin admin)
        {
            Admins = await _data.admin_info.ToListAsync();
            var dbAdmin = await _data.admin_info.FindAsync(admin.Id);
            if (dbAdmin != null)
            {
                _data.Entry(dbAdmin).CurrentValues.SetValues(admin);
                await _data.SaveChangesAsync();
            }
            return Admins;
        }
    }
}
