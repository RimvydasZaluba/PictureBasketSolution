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
            if (_orders.Any(o => o.Id == order.OrderId))
            {
                throw new ArgumentException("This orer id already exists: " + order.OrderId);
            }

            var newOrder = new Order { Id = order.OrderId, Items = new List<OrderItem>() };

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

            return newOrder.Id;
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