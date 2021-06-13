using PictureBasketApi.Models;
using System.Collections.Generic;

namespace PictureBasketApi.Services.Interfaces
{
    public interface IProductTypeService
    {
        /// <summary>
        /// Retrieve all product types in the system
        /// </summary>
        /// <returns></returns>
        List<ProductType> GetAll();
    }
}