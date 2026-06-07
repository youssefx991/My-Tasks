using Grpc.Net.Client;
using Lab1.OrderingSystem.InventoryService.gRPC.Protos;
using Lab1.OrderingSystem.OrderService.API.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Lab1.OrderingSystem.InventoryService.gRPC.Protos.InventoryServiceProto;
using static Lab1.OrderingSystem.PaymentService.gRPC.Protos.PaymentServiceProto;

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
            var InventoryChannel = GrpcChannel.ForAddress("https://localhost:7016");
            var inventoryClient = new InventoryServiceProtoClient(InventoryChannel);

            var PaymentChannel = GrpcChannel.ForAddress("https://localhost:7264");
            var paymentClient = new PaymentServiceProtoClient(PaymentChannel);

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
