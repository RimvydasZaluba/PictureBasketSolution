using System.Collections.Generic;

namespace PictureBasketApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<OrderItem> Items { get; set; }
    }
}