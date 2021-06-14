using PictureBasketApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PictureBasketApi.Utils
{
    public static class BinWidthCalculator
    {
        public static double Calculate(Order order)
        {
            if (order.Items is null)
            {
                return 0;
            }

            double binWidth = 0;

            foreach (var item in order.Items)
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