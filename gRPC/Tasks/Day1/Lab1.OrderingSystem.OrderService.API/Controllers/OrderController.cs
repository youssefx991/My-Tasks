using Lab1.OrderingSystem.OrderService.API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.OrderingSystem.OrderService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpPost("create")]
        public IActionResult CreateOrder(OrderDTO order)
        {
            if (order == null)
            {
                _logger.LogWarning("Received null order in CreateOrder.");
                return BadRequest("Order cannot be null.");
            }

            _logger.LogInformation("Creating order for user {UserId} with {ItemCount} items.", order.UserId, order.Items?.Count ?? 0);
            return Ok(order);


        }
    }
}
