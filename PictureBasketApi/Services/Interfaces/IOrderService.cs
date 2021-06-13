using PictureBasketApi.Models;

namespace PictureBasketApi.Services.Interfaces
{
    public interface IOrderService
    {
        /// <summary>
        /// Get Order by unique ID
        /// </summary>
        /// <param name="id">order id</param>
        /// <returns></returns>
        Order GetById(int id);

        /// <summary>
        /// Create an Order record
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        int Create(Order order);
    }
}