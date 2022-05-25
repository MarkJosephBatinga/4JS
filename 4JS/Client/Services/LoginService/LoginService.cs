using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using _4JS.Shared;

namespace _4JS.Client.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly HttpClient _http;

        public LoginService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Admin> GetAdmin(string email)
        {
            var result = await _http.GetFromJsonAsync<Admin>($"api/login/admin/{email}");
            return result;
        }

        public async Task<User> GetUser(string email)
        {
            var result = await _http.GetFromJsonAsync<User>($"api/login/user/{email}");
            return result;
        }

        public async Task<Admin> LoginAdmin(LoginToken LoginAdmin)
        {
            var result = await _http.PostAsJsonAsync("api/login/admin", LoginAdmin);
            var status = await result.Content.ReadFromJsonAsync<Admin>();
            return status;
        }

        public async Task<User> LoginUser(LoginToken LoginUser)
        {
            var result = await _http.PostAsJsonAsync("api/login/user", LoginUser);
            var status = await result.Content.ReadFromJsonAsync<User>();
            return status;
        }
    }
}
