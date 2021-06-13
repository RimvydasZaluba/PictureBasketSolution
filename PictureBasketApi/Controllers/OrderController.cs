using Microsoft.AspNetCore.Mvc;
using PictureBasketApi.Models;
using PictureBasketApi.Services.Interfaces;
using System.Linq;

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
            var order = _orderService.GetById(id);

            // calclate bin width

            double binWidth = 0;

            order.Items.Sum(o => (o.Product.Width * o.Quantity));

            foreach (var item in order.Items)
            {
                int multiplier = item.Product.StackLimit > 1
                    ? (item.Quantity / item.Product.StackLimit + 1)
                    : item.Quantity;

                binWidth += item.Product.Width * multiplier;
            }

            return Ok(order);
        }
    }
}