using ITI46.Ecommerce.Core.Ordering.Entities.InventoryAggregate;
using ITI46.Ecommerce.Core.Ordering.Interfaces;
using ITI46.Ecommerce.Core.Ordering.Interfaces.Externals.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI46.Ecommerce.Infrastructure.Externals.Inventory
{
    public class ThiredPartyInventoryConnector : IThiredPartyInventoryConnector
    {
        private readonly IThirdPartyInventoryClient thirdPartyInventoryClient;

        public ThiredPartyInventoryConnector(IThirdPartyInventoryClient thirdPartyInventoryClient)
        {
            this.thirdPartyInventoryClient = thirdPartyInventoryClient;
        }

        public async Task<Core.Ordering.Entities.InventoryAggregate.Inventory> CheckQuantity(IEnumerable<(int productId, int quantity)> products)
        {

            var inventory = new Core.Ordering.Entities.InventoryAggregate.Inventory();

            foreach (var product in products)
            {
                var response = await thirdPartyInventoryClient.CheckBalance(product.productId, product.quantity);

                var inventoryItem = new InventoryItem { ProductId = product.productId, Quantity = response.CurrentBalance };

                inventory.AddItem(inventoryItem);
            }

            return inventory;
        }
    }
}
