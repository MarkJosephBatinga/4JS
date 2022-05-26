using _4JS.Server.Data;
using _4JS.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4JS.Server.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _data;

        public OrderService(DataContext data)
        {
            _data = data;
        }

        List<Order> Orders = new List<Order>();
        Order order = new Order();

        public async Task<List<Order>> AddOrder(Order order)
        {
            await _data.order_info.AddAsync(order);
            await _data.SaveChangesAsync();
            return Orders = await _data.order_info.ToListAsync();
        }

        public async Task<Order> GetOrder(int orderId)
        {
            return order = await _data.order_info.Where(a => a.Id == orderId).FirstOrDefaultAsync();
        }

        public async Task<List<Order>> LoadAllOrders()
        {
            return Orders = await _data.order_info.ToListAsync();
        }

        public async Task<List<Order>> RemoveOrder(Order order)
        {
            _data.order_info.Remove(order);
            await _data.SaveChangesAsync();
            Orders = await _data.order_info.ToListAsync();
            return Orders;
        }

        public async Task<List<Order>> UpdateOrder(Order order)
        {
            Orders = await _data.order_info.ToListAsync();
            var dbOrders = await _data.order_info.FindAsync(order.Id);
            if (dbOrders != null)
            {
                _data.Entry(dbOrders).CurrentValues.SetValues(order);
                await _data.SaveChangesAsync();
            }
            return Orders;
        }
    }
}
