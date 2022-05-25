using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using _4JS.Shared;

namespace _4JS.Client.Services.AdminService
{
    public class AdminService : IAdminService
    {
        private readonly HttpClient _http;

        public AdminService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Admin>> AddAdmin(Admin admin)
        {
            var result = await _http.PostAsJsonAsync("api/admin/create", admin);
            var status = await result.Content.ReadFromJsonAsync<List<Admin>>();
            return status;
        }

        public async Task<List<Admin>> DeleteAdmin(Admin admin)
        {
            var result = await _http.PostAsJsonAsync("api/admin/delete", admin);
            var status = await result.Content.ReadFromJsonAsync<List<Admin>>();
            return status;
        }

        public async Task<Admin> GetAdmin(int Id)
        {
            var result = await _http.GetFromJsonAsync<Admin>($"api/admin/display/{Id}");
            return result;
           
        }

        public async Task<List<Admin>> GetAllAdmin()
        {
            var result = await _http.GetFromJsonAsync<List<Admin>>($"api/user/displayall");
            return result;
        }

        public async Task<List<Admin>> UpdateAdmin(Admin admin)
        {

            var result = await _http.PostAsJsonAsync("api/admin/update", admin);
            var status = await result.Content.ReadFromJsonAsync<List<Admin>>();
            return status;
        }
    }
}
