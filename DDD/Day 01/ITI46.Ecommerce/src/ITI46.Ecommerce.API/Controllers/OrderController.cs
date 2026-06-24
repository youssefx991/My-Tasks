using ITI46.Ecommerce.Core.Ordering.Interfaces;
using ITI46.Ecommerce.Core.Ordering.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITI46.Ecommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService) => this.orderService = orderService;


        [HttpGet("ping")]
        public IActionResult Get() => Ok("pong");

        [HttpPost]
        public async Task<IActionResult> Post(Order order)
        {
            var creationResult = await orderService.PlaceOrder(order);

            return creationResult.Success ? Created("", new { Id = creationResult.OrderId }) : BadRequest();
        }
    }
}
