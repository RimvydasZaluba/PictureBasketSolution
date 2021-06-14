using PictureBasketApi.Models;
using PictureBasketApi.Repositories.Interfaces;
using PictureBasketApi.Services.Interfaces;
using System.Collections.Generic;

namespace PictureBasketApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public int Create(CreateOrderModel order)
        {
            return _orderRepository.Create(order);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }
    }
}