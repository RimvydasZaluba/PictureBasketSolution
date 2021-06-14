using PictureBasketApi.Models;
using System.Linq;

namespace PictureBasketApi.Utils
{
    public static class Mapper
    {
        public static OrderDto MapOrder(Order order)
        {
            return new OrderDto
            {
                Id = order.Id,
                Items = order.Items
                    .Select(x =>
                        new OrderItemDto
                        {
                            ProductName = x.Product.Title,
                            Quantity = x.Quantity
                        })
                    .ToList(),
                RequiredBinWidth = BinWidthCalculator.Calculate(order)
            };
        }
    }
}