using PictureBasketApi.Models;

namespace PictureBasketApi.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        /// <summary>
        /// Create an Order record
        /// </summary>
        /// <param name="order"></param>
        int Create(Order order);

        /// <summary>
        /// Retrieve Order by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Order GetById(int id);
    }
}