using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _4JS.Server.Services.AdminService;
using _4JS.Shared;

namespace VMS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _service;

        public AdminController(IAdminService service)
        {
            _service = service;
        }
        List<Admin> Admins = new List<Admin>();
        Admin admin = new Admin();

        [HttpPost("create")]
        public async Task<ActionResult<List<Admin>>> LoginAdmin(Admin admin)
        {
            return Admins = await _service.AddAdmin(admin);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Admin>>> UpdateUser(Admin admin)
        {
            return Admins = await _service.UpdateAdmin(admin);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Admin>>> DeleteUser(Admin admin)
        {
            return Admins = await _service.RemoveAdmin(admin);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Admin>>> GetAllUser()
        {
            return Admins = await _service.LoadAllAdmins();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Admin>> GetUser(int Id)
        {
            return admin = await _service.GetAdmin(Id);
        }
    }
}
