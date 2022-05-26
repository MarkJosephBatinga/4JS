using _4JS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace _4JS.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _http;

        public OrderService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Order>> AddOrder(Order order)
        {
            var result = await _http.PostAsJsonAsync("api/order/create", order);
            var status = await result.Content.ReadFromJsonAsync<List<Order>>();
            return status;
        }

        public async Task<List<Order>> DeleteOrder(Order order)
        {

            var result = await _http.PostAsJsonAsync("api/order/delete", order);
            var status = await result.Content.ReadFromJsonAsync<List<Order>>();
            return status;
        }

        public async Task<List<Order>> GetAllOrder()
        {
            var result = await _http.GetFromJsonAsync<List<Order>>($"api/order/displayall");
            return result;
        }

        public async Task<Order> GetOrder(int Id)
        {
            var result = await _http.GetFromJsonAsync<Order>($"api/order/display/{Id}");
            return result;
        }

        public async Task<List<Order>> UpdateOrderk(Order order)
        {
            var result = await _http.PostAsJsonAsync("api/order/update", order);
            var status = await result.Content.ReadFromJsonAsync<List<Order>>();
            return status;
        }
    }
}
