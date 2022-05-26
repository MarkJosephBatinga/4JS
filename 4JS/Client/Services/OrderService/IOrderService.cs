using _4JS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4JS.Client.Services.OrderService
{
    interface IOrderService
    {
        Task<List<Order>> AddOrder(Order order);

        Task<List<Order>> UpdateOrderk(Order order);

        Task<List<Order>> DeleteOrder(Order order);

        Task<List<Order>> GetAllOrder();

        Task<Order> GetOrder(int Id);
    }
}
