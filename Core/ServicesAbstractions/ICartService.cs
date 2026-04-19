using Domain.Entities.Cart;
using Shared.Contracts.Request.Cart;
using Shared.Contracts.Response.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAbstractions
{
    public interface ICartService
    {
        Task<AddItemToCartResponse> AddItemToCartAsync(AddItemToCartRequest request);
        Task<RemoveItemFromCartResponse> RemoveItemFromCartAsync(RemoveItemFromCartRequest request);
        Task<IEnumerable<CartItem>> GetCartItemsAsync();
        Task<decimal> GetCartTotalAsync();
        Task<int> CartItemCountAsync();
        Task<FetchCartResponse> FetchCartAsync();
        Task<string> UniqueCartIdAsync();

    }
}
