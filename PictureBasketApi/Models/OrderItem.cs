using System;

namespace PictureBasketApi.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public ProductType Product { get; set; }
        public int Quantity { get; set; }
    }
}