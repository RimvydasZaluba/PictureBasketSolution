using PictureBasketApi.Models;
using PictureBasketApi.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PictureBasketApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private static List<Order> _orders = new List<Order>();

        public int Create(Order order)
        {
            var nextId = _orders.Any() ? _orders.Max(o => o.Id) + 1 : 1;
            order.Id = nextId;

            _orders.Add(order);

            return nextId;
        }

        public Order GetById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }
    }
}