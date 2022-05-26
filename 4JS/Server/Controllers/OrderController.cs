using _4JS.Server.Services.OrderService;
using _4JS.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4JS.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        List<Order> Orders = new List<Order>();
        Order order = new Order();

        [HttpPost("create")]
        public async Task<ActionResult<List<Order>>> LoginOrder(Order order)
        {
            return Orders = await _service.AddOrder(order);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Order>>> UpdateOrder(Order order)
        {
            return Orders = await _service.UpdateOrder(order);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Order>>> DeleteOrder(Order order)
        {
            return Orders = await _service.RemoveOrder(order);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Order>>> GetAllOrder()
        {
            return Orders = await _service.LoadAllOrders();
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Order>> GetOrder(int Id)
        {
            return order = await _service.GetOrder(Id);
        }
    }
}
