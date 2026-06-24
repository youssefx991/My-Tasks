using ITI46.Ecommerce.Core.Ordering.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI46.Ecommerce.Core.Ordering.Interfaces.Externals.Inventory
{
    public interface IThirdPartyInventoryClient
    {
        Task<ThirdPartyIventoryResponse> CheckBalance(int productId, int quantity);
    }
}
