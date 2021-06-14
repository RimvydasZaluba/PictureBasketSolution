using System.Collections.Generic;

namespace PictureBasketApi.Models
{
    public class CreateOrderModel
    {
        public List<CreateOrderItemModel> Items { get; set; }
    }
}