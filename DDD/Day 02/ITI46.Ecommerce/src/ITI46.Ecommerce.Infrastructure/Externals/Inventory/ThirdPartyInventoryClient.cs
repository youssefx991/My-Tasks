using ITI46.Ecommerce.Core.Ordering.DTO;
using ITI46.Ecommerce.Core.Ordering.Interfaces.Externals.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI46.Ecommerce.Infrastructure.Externals.Inventory
{
    public class ThirdPartyInventoryClient : IThirdPartyInventoryClient
    {
        private readonly HttpClient httpClient;

        public ThirdPartyInventoryClient(HttpClient httpClient) => this.httpClient = httpClient;

        public Task<ThirdPartyIventoryResponse> CheckBalance(int productId, int quantity)
        {
           // httpClient.SendAsync();

            return Task.FromResult(new ThirdPartyIventoryResponse
            {
                IsAvailable = true,
                CurrentBalance = 100
            });
        }
    }
}
