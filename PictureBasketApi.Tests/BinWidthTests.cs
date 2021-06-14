using NUnit.Framework;
using PictureBasketApi.Models;
using PictureBasketApi.Utils;
using System.Collections.Generic;
using System.Linq;

namespace PictureBasketApi.Tests
{
    public class Tests
    {
        private static readonly List<ProductType> _productTypes = new List<ProductType>
        {
            new ProductType {Id = 1, Title = "PhotoBook", Width = 19, StackLimit = 1},
            new ProductType {Id = 2, Title = "Calendar", Width = 10, StackLimit = 1},
            new ProductType {Id = 3, Title = "Canvas", Width = 16, StackLimit = 1},
            new ProductType {Id = 4, Title = "Set of Greeting Cards", Width = 4.7, StackLimit = 1},
            new ProductType {Id = 5, Title = "Mug", Width = 94, StackLimit = 4},
        };

        private static object[] testOrders =
        {
            new object[] {new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem {Product = _productTypes[1], Quantity = 1},
                    new OrderItem {Product = _productTypes[2], Quantity = 1},
                    new OrderItem {Product = _productTypes[4], Quantity = 1}
                }
            },
            120
            },
            new object[] {new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem {Product = _productTypes[1], Quantity = 1},
                    new OrderItem {Product = _productTypes[2], Quantity = 1},
                    new OrderItem {Product = _productTypes[4], Quantity = 4}
                }
            },
            120
            },
            new object[] {new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem {Product = _productTypes[1], Quantity = 2},
                    new OrderItem {Product = _productTypes[4], Quantity = 3}
                }
            },
            114
            },
            new object[] {new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem {Product = _productTypes[2], Quantity = 1},
                    new OrderItem {Product = _productTypes[4], Quantity = 7}
                }
            },
            204
            },
            new object[] {new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem {Product = _productTypes[1], Quantity = 5}
                }
            },
            50
            },
            new object[] {new Order
            {
                Items = new List<OrderItem>
                {
                    new OrderItem {Product = _productTypes[2], Quantity = 0},
                    new OrderItem {Product = _productTypes[4], Quantity = 8}
                }
            },
            188
            }
    };

        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(nameof(testOrders))]
        public void GivenValidOrderBinSizeShouldBeCorrect(Order order, double expectedResult)
        {
            var result = BinWidthCalculator.Calculate(order);

            Assert.AreEqual(expectedResult, result);
        }
    }
}