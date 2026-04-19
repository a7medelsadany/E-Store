using AutoMapper;
using Domain.Contrats;
using Domain.Entities.Cart;
using Domain.Entities.ProductModule;
using Microsoft.AspNetCore.Http;
using ServicesAbstractions;
using Shared.Contracts.Request.Cart;
using Shared.Contracts.Response.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CartService(IHttpContextAccessor httpContext, ICartRepository cartRepository,
        ICartItemRepository cartItemRepository,IGenericRepository<Product> _productRepository
        , IMapper mapper) : ICartService
    {
        public Task<AddItemToCartResponse> AddItemToCartAsync(AddItemToCartRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> CartItemCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FetchCartResponse> FetchCartAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartItem>> GetCartItemsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetCartTotalAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RemoveItemFromCartResponse> RemoveItemFromCartAsync(RemoveItemFromCartRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<string> UniqueCartIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
