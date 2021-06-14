using PictureBasketApi.Models;
using System.Collections.Generic;

namespace PictureBasketApi.Services.Interfaces
{
    public interface IOrderService
    {
        /// <summary>
        /// Get order by unique ID
        /// </summary>
        /// <param name="id">order id</param>
        /// <returns></returns>
        Order GetById(int id);

        /// <summary>
        /// Create an order record
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        int Create(CreateOrderModel order);

        /// <summary>
        /// Retrieve all Orders
        /// </summary>
        /// <returns></returns>
        List<Order> GetAll();
    }
}