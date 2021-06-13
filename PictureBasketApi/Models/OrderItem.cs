namespace PictureBasketApi.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public ProductType Product { get; set; }
        public int Quantity { get; set; }
    }
}
