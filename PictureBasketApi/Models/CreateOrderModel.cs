using System.Collections.Generic;

namespace PictureBasketApi.Models
{
    public class CreateOrderModel
    {
        public int OrderId { get; set; }
        public List<CreateOrderItemModel> Items { get; set; }
    }
}