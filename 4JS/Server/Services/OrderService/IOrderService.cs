using _4JS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4JS.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<List<Order>> AddOrder(Order order);

        Task<Order> GetOrder(int orderId);

        Task<List<Order>> UpdateOrder(Order order);

        Task<List<Order>> RemoveOrder(Order order);

        Task<List<Order>> LoadAllOrders();
    }
}
