using Microsoft.AspNetCore.Mvc;
using PictureBasketApi.Models;

namespace PictureBasketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            return Ok();
        }

        public IActionResult GetById(int id)
        {
            return Ok(new Order());
        }
    }
}