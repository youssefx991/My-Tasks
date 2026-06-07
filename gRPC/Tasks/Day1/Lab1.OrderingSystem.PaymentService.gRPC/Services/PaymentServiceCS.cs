using Grpc.Core;
using Lab1.OrderingSystem.PaymentService.gRPC.Models;
using Lab1.OrderingSystem.PaymentService.gRPC.Protos;
using static Lab1.OrderingSystem.PaymentService.gRPC.Protos.PaymentServiceProto;

namespace Lab1.OrderingSystem.PaymentService.gRPC.Services
{
    public class PaymentServiceCS : PaymentServiceProtoBase
    {
        private readonly ILogger<PaymentServiceCS> _logger;
        public PaymentServiceCS(ILogger<PaymentServiceCS> logger)
        {
            _logger = logger;
        }

        public override Task<DeductBalanceResponse> DeductBalance(DeductBalanceRequest request, ServerCallContext context)
        {
            _logger.LogInformation("Received DeductBalance request for user id {Id} with name {Name} and required amount {RequiredAmount}", request.Id, request.Name, request.RequiredAmount);
            if (request == null || request.Id == null || request.RequiredAmount == null || request.Name == null) {
                _logger.LogError("Invalid request some data is null: {Request}", request);
                return Task.FromResult(new DeductBalanceResponse { Success = false, Message = "Invalid request data" });
            }

            
            var user = UsersList.Users.FirstOrDefault(u => u.id == request.Id);
            if (user == null)
            {
                _logger.LogError("User with id {Id} and name {Name} not found", request.Id, request.Name);
                return Task.FromResult(new DeductBalanceResponse { Success = false, Message = "User not found" });
            }

            _logger.LogInformation("User found: {User}", user);
            
            if (request.RequiredAmount > user.Balance)
            {
                _logger.LogWarning("User with id {Id} and name {Name} has insufficient balance. Required: {RequiredAmount}, Available: {Balance}", request.Id, request.Name, request.RequiredAmount, user.Balance);
                return Task.FromResult(new DeductBalanceResponse { Success = false, Message = "Insufficient balance" });
            }

            user.Balance -= request.RequiredAmount;
            _logger.LogInformation("Balance updated for user {Id}: {Balance}", request.Id, user.Balance);

            return Task.FromResult(new DeductBalanceResponse { Success = true, Message = "Balance deducted successfully" });
        }
    }
}
