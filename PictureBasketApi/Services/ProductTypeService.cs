using PictureBasketApi.Models;
using PictureBasketApi.Repositories.Interfaces;
using PictureBasketApi.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PictureBasketApi.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IProductTypeRepository _productTypeRepository;

        public ProductTypeService(IProductTypeRepository productTypeRepository)
        {
            this._productTypeRepository = productTypeRepository;
        }

        public List<ProductType> GetAll()
        {
            return _productTypeRepository.GetAll().ToList();
        }
    }
}