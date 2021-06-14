using PictureBasketApi.Models;
using PictureBasketApi.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PictureBasketApi.Repositories
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private static readonly List<ProductType> _productTypes = new List<ProductType>
        {
            new ProductType {Id = 1, Title = "PhotoBook", Width = 19, StackLimit = 1},
            new ProductType {Id = 2, Title = "Calendar", Width = 10, StackLimit = 1},
            new ProductType {Id = 3, Title = "Canvas", Width = 16, StackLimit = 1},
            new ProductType {Id = 4, Title = "Set of Greeting Cards", Width = 4.7, StackLimit = 1},
            new ProductType {Id = 5, Title = "Mug", Width = 94, StackLimit = 4},
        };

        public List<ProductType> GetAll()
        {
            return _productTypes;
        }

        public ProductType GetById(int id)
        {
            return _productTypes.FirstOrDefault(o => o.Id == id);
        }
    }
}