using PictureBasketApi.Models;
using PictureBasketApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PictureBasketApi.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private static List<Order> _orders = new List<Order>();
        private readonly IProductTypeRepository _productTypeRepository;

        public OrderRepository(IProductTypeRepository productTypeRepository)
        {
            this._productTypeRepository = productTypeRepository;
        }

        public int Create(CreateOrderModel order)
        {
            var nextId = _orders.Any() ? _orders.Max(o => o.Id) + 1 : 1;
            var newOrder = new Order { Id = nextId, Items = new List<OrderItem>() };

            foreach (var item in order.Items)
            {
                newOrder.Items.Add(new OrderItem
                {
                    Id = Guid.NewGuid(),
                    Quantity = item.Quantity,
                    Product = _productTypeRepository.GetById(item.ProductId)
                });
            }

            _orders.Add(newOrder);

            return nextId;
        }

        public List<Order> GetAll()
        {
            return _orders;
        }

        public Order GetById(int id)
        {
            return _orders.FirstOrDefault(o => o.Id == id);
        }
    }
}