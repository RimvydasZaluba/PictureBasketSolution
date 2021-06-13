using Microsoft.AspNetCore.Mvc;
using PictureBasketApi.Models;
using PictureBasketApi.Services.Interfaces;

namespace PictureBasketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            this._orderService = orderService;
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            var newId = _orderService.Create(order);

            return Ok(newId);
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_orderService.GetById(id));
        }
    }
}