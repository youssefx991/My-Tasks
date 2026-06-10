using Grpc.Core;
using Lab1.OrderingSystem.InventoryService.gRPC.Models;
using Lab1.OrderingSystem.OrderService.API.Server.DTOs;
using Lab1.OrderingSystem.PaymentService.gRPC.Models;
using static Lab1.OrderingSystem.OrderService.API.Server.OrderServiceProto;

namespace Lab1.OrderingSystem.OrderService.API.Server.Services
{
    public class OrderService : OrderServiceProtoBase
    {
        private readonly ILogger<OrderService> _logger;
        public OrderService(ILogger<OrderService> logger)
        {
            _logger = logger;
        }

        public override Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Received CreateOrder request : {request}", request);


            List<ItemDTO> items = new List<ItemDTO>();
            var requiredAmount = 0;

            foreach (var item in request.Items)
            {
                _logger.LogInformation("Processing item {ItemId} with quantity {Quantity} and price {Price}.", item.Id, item.Quantity, item.Price);
                items.Add(new ItemDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Quantity = item.Quantity,
                    Price = item.Price
                });

                requiredAmount += (item.Quantity == null ? 0 : item.Quantity) * (item.Price == null ? 0 : item.Price);
            }
            _logger.LogInformation("Total required amount for order: {RequiredAmount}.", requiredAmount);

            _logger.LogInformation("Checking inventory for user {UserId} with {ItemCount} items.", request.Userid, items.Count);

            // inventory check 
            _logger.LogInformation("Deducting quantity from inventory. with request of {Request.Count} Items", request?.Items?.Count ?? 0);

            if (request?.Items == null || request?.Items?.Count == 0)
            {
                _logger.LogWarning("Received invalid request in DeductQuantity.");
                return Task.FromResult(new CreateOrderResponse
                {
                    Success = false,
                    Message = "No items provided in the request."
                });
            }

            foreach (var item in request?.Items)
            {
                _logger.LogInformation("Processing item with ID: {ItemId}, Name: {ItemName}, Quantity: {ItemQuantity}", item?.Id, item?.Name, item?.Quantity);
                if (item == null)
                {
                    _logger.LogWarning("Received null item in DeductQuantity.");
                    return Task.FromResult(new CreateOrderResponse
                    {
                        Success = false,
                        Message = "One or more items in the request are null."
                    });

                }
                var itemExists = ItemsList.Items.Any(i => i.Id == item.Id);
                if (!itemExists)
                {
                    _logger.LogWarning("Item with ID: {ItemId} and name: {ItemName} does not exist in inventory.", item.Id, item.Name);
                    return Task.FromResult(new CreateOrderResponse
                    {
                        Success = false,
                        Message = $"Item with ID: {item.Id} and name: {item.Name} does not exist in inventory."
                    });
                }

                var enoughQuantity = ItemsList.Items.Any(i => i.Id == item.Id && i.Quantity >= item.Quantity);
                if (!enoughQuantity)
                {
                    _logger.LogWarning("Item with ID: {ItemId} and name: {ItemName} has insufficient quantity.", item.Id, item.Name);
                    return Task.FromResult(new CreateOrderResponse
                    {
                        Success = false,
                        Message = $"Item with ID: {item.Id} and name: {item.Name} has insufficient quantity."
                    });
                }

                _logger.LogInformation("Found item with ID: {ItemId} and name: {ItemName} in inventory. Deducting quantity.", item.Id, item.Name);
                var inventoryItem = ItemsList.Items.First(i => i.Id == item.Id);
                if (inventoryItem == null)
                {
                    _logger.LogWarning("Unexpected error: Item with ID: {ItemId} and name: {ItemName} was not found in inventory during deduction.", item.Id, item.Name);
                    return Task.FromResult(new CreateOrderResponse
                    {
                        Success = false,
                        Message = $"Unexpected error: Item with ID: {item.Id} and name: {item.Name} was not found in inventory during deduction."
                    });
                }

                inventoryItem.Quantity -= item.Quantity;

            }


            _logger.LogInformation("Inventory check passed for user {UserId}. Proceeding to payment deduction.", request.Userid);
            _logger.LogInformation("Deducting balance for user {UserId} with amount {Amount}.", request.Userid, requiredAmount);

            // payment check
            _logger.LogInformation("Received DeductBalance request for user id {Id} with name {Name} and required amount {RequiredAmount}", request.Id, request.Username, requiredAmount);
            if (request == null || request.Id == null || requiredAmount == null || request.Username == null)
            {
                _logger.LogError("Invalid request some data is null: {Request}", request);
                return Task.FromResult(new CreateOrderResponse { Success = false, Message = "Invalid request data" });
            }


            var user = UsersList.Users.FirstOrDefault(u => u.id == request.Userid);
            if (user == null)
            {
                _logger.LogError("User with id {Id} and name {Name} not found", request.Id, request.Username);
                return Task.FromResult(new CreateOrderResponse { Success = false, Message = "User not found" });
            }

            _logger.LogInformation("User found: {User}", user);

            if (requiredAmount > user.Balance)
            {
                _logger.LogWarning("User with id {Id} and name {Name} has insufficient balance. Required: {RequiredAmount}, Available: {Balance}", request.Id, request.Username, requiredAmount, user.Balance);
                return Task.FromResult(new CreateOrderResponse { Success = false, Message = "Insufficient balance" });
            }

            user.Balance -= requiredAmount;
            _logger.LogInformation("Balance updated for user {Id}: {Balance}", request.Id, user.Balance);


            _logger.LogInformation("Payment deduction successful for user {UserId}. Order created successfully.", request.Userid);
            _logger.LogInformation("Order details: UserId={UserId}, UserName={UserName}, ItemCount={ItemCount}, RequiredAmount={RequiredAmount}.", request.Userid, request.Username, items.Count, requiredAmount);
            return Task.FromResult(new CreateOrderResponse { Success = true, Message = "Order created successfully." });
            
        }
    }
}
