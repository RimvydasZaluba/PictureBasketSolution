using PictureBasketApi.Models;
using System.Collections.Generic;

namespace PictureBasketApi.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Create an order record
        /// </summary>
        /// <param name="order"></param>
        int Create(CreateOrderModel order);

        /// <summary>
        /// Retrieve order by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Order GetById(int id);

        /// <summary>
        /// Retrieve all orders
        /// </summary>
        /// <returns></returns>
        List<Order> GetAll();
    }
}