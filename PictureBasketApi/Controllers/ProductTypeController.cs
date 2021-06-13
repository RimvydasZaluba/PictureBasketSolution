using Microsoft.AspNetCore.Mvc;
using PictureBasketApi.Services.Interfaces;

namespace PictureBasketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeService _productTypeService;

        public ProductTypeController(IProductTypeService productTypeService)
        {
            this._productTypeService = productTypeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productTypeService.GetAll());
        }
    }
}