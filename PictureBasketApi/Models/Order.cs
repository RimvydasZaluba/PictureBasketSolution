using System.Collections.Generic;

namespace PictureBasketApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; }

        public double RequiredBinWidth
        {
            get
            {
                if (this.Items is null)
                {
                    return 0;
                }

                double binWidth = 0;

                foreach (var item in this.Items)
                {
                    int multiplier = item.Quantity;

                    if (item.Product.StackLimit > 1)
                    {
                        multiplier = item.Quantity / item.Product.StackLimit +
                            (item.Quantity % item.Product.StackLimit > 0 ? 1 : 0);
                    }

                    binWidth += item.Product.Width * multiplier;
                }

                return binWidth;
            }
        }
    }
}