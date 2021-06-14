using System.Collections.Generic;

namespace PictureBasketApi.Models
{
    public class OrderDto
    {
        public int Id { get; set; }
        public List<OrderItemDto> Items { get; set; }
        public double RequiredBinWidth { get; set; }
    }
}