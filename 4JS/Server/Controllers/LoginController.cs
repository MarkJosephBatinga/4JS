using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Server.Services.LoginService;
using _4JS.Shared;

namespace _4JS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }

        User user = new User();
        Admin admin = new Admin();

        [HttpPost("user")]
        public async Task<ActionResult<User>> LoginAsUser(LoginToken LoginUser)
        {
            return user = await _service.LoginUser(LoginUser);
        }

        [HttpGet("user/{email}")]
        public async Task<ActionResult<User>> GetUser(string email)
        {
            return user = await _service.GetUser(email);
        }

        [HttpPost("admin")]
        public async Task<ActionResult<Admin>> LoginAsAdmin(LoginToken LoginUser)
        {
            return admin = await _service.LoginAdmin(LoginUser);
        }

        [HttpGet("admin/{email}")]
        public async Task<ActionResult<Admin>> GetAdmin(string email)
        {
            return admin = await _service.GetAdmin(email);
        }
    }
}
