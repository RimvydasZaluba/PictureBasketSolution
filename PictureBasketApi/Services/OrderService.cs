using PictureBasketApi.Models;
using PictureBasketApi.Repositories.Interfaces;
using PictureBasketApi.Services.Interfaces;

namespace PictureBasketApi.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public int Create(Order order)
        {
            return _orderRepository.Create(order);
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }
    }
}