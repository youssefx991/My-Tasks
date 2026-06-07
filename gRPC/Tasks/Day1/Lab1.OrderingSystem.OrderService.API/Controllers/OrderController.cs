using Grpc.Net.Client;
using Lab1.OrderingSystem.InventoryService.gRPC.Protos;
using Lab1.OrderingSystem.OrderService.API.DTOs;
using Lab1.OrderingSystem.PaymentService.gRPC.Protos;
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
        public async Task<IActionResult> CreateOrder(OrderDTO order)
        {
            _logger.LogInformation("Received CreateOrder request {order}.", order);
            var InventoryChannel = GrpcChannel.ForAddress("https://localhost:7016");
            var inventoryClient = new InventoryServiceProtoClient(InventoryChannel);

            var PaymentChannel = GrpcChannel.ForAddress("https://localhost:7264");
            var paymentClient = new PaymentServiceProtoClient(PaymentChannel);


            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Received invalid order in CreateOrder.");
                return BadRequest(ModelState);                
            }

            List<ItemDTO> items = new List<ItemDTO>();
            var requiredAmount = 0;

            foreach (var item in order.Items ?? new List<ItemDTO>())
            {
                _logger.LogInformation("Processing item {ItemId} with quantity {Quantity} and price {Price}.", item.Id, item.Quantity, item.Price);
                items.Add(item);
                requiredAmount += (item.Quantity ?? 0) * (item.Price ?? 0);
            }
            _logger.LogInformation("Total required amount for order: {RequiredAmount}.", requiredAmount);
            
            _logger.LogInformation("Checking inventory for user {UserId} with {ItemCount} items.", order.UserId, items.Count);
            var inventoryResponse = await inventoryClient.DeductQuantityAsync(new DeductQuantityRequest
            {
                Items =
                {
                    items.Select(i => new Item
                    {
                        Id = i.Id ?? 0,
                        Name = i.Name ?? string.Empty,
                        Quantity = i.Quantity ?? 0,
                    })
                }
            });

            if (!inventoryResponse.Success)
            {
                _logger.LogWarning("Inventory check failed for user {UserId}. Message: {Message}", order.UserId, inventoryResponse.Message);
                return BadRequest(new { Message = "Inventory check failed: " + inventoryResponse.Message });
            }

            _logger.LogInformation("Inventory check passed for user {UserId}. Proceeding to payment deduction.", order.UserId);
            _logger.LogInformation("Deducting balance for user {UserId} with amount {Amount}.", order.UserId, requiredAmount);
            var paymentResponse = await paymentClient.DeductBalanceAsync(new DeductBalanceRequest
            {
                Id = order.UserId ?? 0,
                Name = order.UserName ?? string.Empty,
                RequiredAmount = requiredAmount
            });

            if (!paymentResponse.Success)
            {
                _logger.LogWarning("Payment deduction failed for user {UserId}. Message: {Message}", order.UserId, paymentResponse.Message);
                return BadRequest(new { Message = "Payment deduction failed: " + paymentResponse.Message });
            }

            _logger.LogInformation("Payment deduction successful for user {UserId}. Order created successfully.", order.UserId);
            _logger.LogInformation("Order details: UserId={UserId}, UserName={UserName}, ItemCount={ItemCount}, RequiredAmount={RequiredAmount}.", order.UserId, order.UserName, items.Count, requiredAmount);
            return Ok(new { Message = "Order created successfully." });


        }
    }
}
