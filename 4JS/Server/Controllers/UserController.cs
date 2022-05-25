using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Server.Services.UserService;
using _4JS.Shared;

namespace VMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        List<User> Users = new List<User>();
        User user = new User();

        [HttpPost("create")]
        public async Task<ActionResult<List<User>>> LoginUser(User user)
        {
            return Users = await _service.AddUser(user);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<User>>> UpdateUser(User user)
        {
            return Users = await _service.UpdateUser(user);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<User>>> DeleteUser(User user)
        {
            return Users = await _service.RemoveUser(user);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<User>>> GetAllUser()
        {
            return Users = await _service.LoadAllUsers();
        }

        [HttpGet("unvacc")]
        public async Task<ActionResult<List<User>>> GetAllUnvaccinatedUser()
        {
            return Users = await _service.LoadAllUnvaccinatedUsers();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<User>> GetUser(int Id)
        {
            return user = await _service.GetUser(Id);
        }
    }
}
