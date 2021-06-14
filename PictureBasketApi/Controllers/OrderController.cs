using Microsoft.AspNetCore.Mvc;
using PictureBasketApi.Models;
using PictureBasketApi.Services.Interfaces;
using System;
using System.Linq;

namespace PictureBasketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IProductTypeService _productTypeService;

        public OrderController(IOrderService orderService, IProductTypeService productTypeService)
        {
            this._orderService = orderService;
            this._productTypeService = productTypeService;
        }

        /// <summary>
        /// Create an order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderModel order)
        {
            if (order.Items is null || !order.Items.Any())
            {
                return BadRequest("Order needs to have items to be created");
            }

            var productIds = _productTypeService.GetAll().Select(o => o.Id);
            var nonExistantProductIds = order.Items.Select(o => o.ProductId).Except(productIds);

            if (nonExistantProductIds.Any())
            {
                return BadRequest("Some products do not exist in the system: " + String.Join(", ", nonExistantProductIds));
            }

            var newId = _orderService.Create(order);

            return Ok(newId);
        }

        /// <summary>
        /// Get order by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var order = _orderService.GetById(id);

            if (order is null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        /// <summary>
        /// Get all orders
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_orderService.GetAll());
        }
    }
}