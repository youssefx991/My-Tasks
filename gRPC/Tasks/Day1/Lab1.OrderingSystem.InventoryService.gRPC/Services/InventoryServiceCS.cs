using Grpc.Core;
using Lab1.OrderingSystem.InventoryService.gRPC.Models;
using Lab1.OrderingSystem.InventoryService.gRPC.Protos;
using static Lab1.OrderingSystem.InventoryService.gRPC.Protos.InventoryServiceProto;

namespace Lab1.OrderingSystem.InventoryService.gRPC.Services
{
    public class InventoryServiceCS : InventoryServiceProtoBase
    {
        private readonly ILogger<InventoryServiceCS> _logger;
        public InventoryServiceCS(ILogger<InventoryServiceCS> logger)
        {
            _logger = logger;
        }

        public override Task<DeductQuantityResponse> DeductQuantity(DeductQuantityRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Deducting quantity from inventory. with request of {Request.Count} Items", request?.Items?.Count ?? 0);
            
            if (request?.Items == null || request?.Items?.Count == 0)
            {
                _logger.LogWarning("Received invalid request in DeductQuantity.");
                return Task.FromResult(new DeductQuantityResponse
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
                    return Task.FromResult(new DeductQuantityResponse
                    {
                        Success = false,
                        Message = "One or more items in the request are null."
                    });

                }
                var itemExists = ItemsList.Items.Any(i => i.Id == item.Id);
                if (!itemExists)
                {
                    _logger.LogWarning("Item with ID: {ItemId} and name: {ItemName} does not exist in inventory.", item.Id, item.Name);
                    return Task.FromResult(new DeductQuantityResponse
                    {
                        Success = false,
                        Message = $"Item with ID: {item.Id} and name: {item.Name} does not exist in inventory."
                    });
                }

                var enoughQuantity = ItemsList.Items.Any(i => i.Id == item.Id && i.Quantity >= item.Quantity);
                if (!enoughQuantity)
                {
                    _logger.LogWarning("Item with ID: {ItemId} and name: {ItemName} has insufficient quantity.", item.Id, item.Name);
                    return Task.FromResult(new DeductQuantityResponse
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
                    return Task.FromResult(new DeductQuantityResponse
                    {
                        Success = false,
                        Message = $"Unexpected error: Item with ID: {item.Id} and name: {item.Name} was not found in inventory during deduction."
                    });
                }

                inventoryItem.Quantity -= item.Quantity;

            }
            return Task.FromResult(new DeductQuantityResponse
            {
                Success = true,
                Message = "Quantity deducted successfully."
            });
        }
    }
}
