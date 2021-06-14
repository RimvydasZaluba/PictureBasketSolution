using System.Collections.Generic;

namespace PictureBasketApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}