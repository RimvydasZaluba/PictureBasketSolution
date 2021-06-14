using PictureBasketApi.Models;
using System.Collections.Generic;

namespace PictureBasketApi.Repositories.Interfaces
{
    public interface IProductTypeRepository
    {
        /// <summary>
        /// Retrieve all product types in the system
        /// </summary>
        /// <returns></returns>
        public List<ProductType> GetAll();

        /// <summary>
        /// Get a product type by id
        /// </summary>
        /// <returns></returns>
        public ProductType GetById(int id);
    }
}