using AutoMapper;
using Domain.Contrats;
using Domain.Entities.Cart;
using Domain.Entities.ProductModule;
using ServicesAbstractions;
using Microsoft.AspNetCore.Http;
using Shared.Contracts.Request.Cart;
using Shared.Contracts.Response.Cart;
using Shared.DTOS.CartDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    public class CartService(IHttpContextAccessor _httpContextAccessor, ICartRepository cartRepository,
        ICartItemRepository cartItemRepository,IGenericRepository<Product> _productRepository
        , IMapper mapper) : ICartService
    {
        private const string UniqueCartIdSessionKey = "UniqueCartId";

        #region Add Item
        public async Task<AddItemToCartResponse> AddItemToCartAsync(AddItemToCartRequest request)
        {
            AddItemToCartResponse response = new AddItemToCartResponse();
            var cart = await GetCartAsync();
            if (cart != null)
            {
                var existingCartItem = await cartItemRepository.GetCartItemsByCartIdAsync(cart.Id);
                var cartItem = existingCartItem.FirstOrDefault(ci => ci.ProductId == request.ProductId);

                if (cartItem != null)
                {
                    cartItem.Quantity++;
                    await cartItemRepository.UpdateCartItem(cartItem);
                    response.cartItem = mapper.Map<CartItemDto>(cartItem);
                }
                else
                {
                    var product = await _productRepository.GetByIdAsync(request.ProductId);
                    if (product != null)
                    {
                        cartItem = new CartItem
                        {
                            CartId = cart.Id,
                            Product = product,
                            ProductId = request.ProductId,
                            Quantity = 1,
                        };
                        await cartItemRepository.AddCartItem(cartItem);
                        response.cartItem = mapper.Map<CartItemDto>(cartItem);
                    }
                }
            }
            else
            {
                var product = await _productRepository.GetByIdAsync(request.ProductId);
                if (product != null)
                {
                    var newCart = new Cart
                    {
                        UniqueCartId = await UniqueCartIdAsync(),
                        CartStatus = CartStatus.Open,
                    };
                    cartRepository.AddCart(newCart);

                    var cartItem = new CartItem
                    {
                        CartId = newCart.Id,
                        Cart = newCart,
                        Product = product,
                        ProductId = request.ProductId,
                        Quantity = 1
                    };
                    await cartItemRepository.AddCartItem(cartItem);
                    response.cartItem = mapper.Map<CartItemDto>(cartItem);
                }
            }
            return response;
        }

        #endregion

        #region Remove Item
        public async Task<RemoveItemFromCartResponse> RemoveItemFromCartAsync(RemoveItemFromCartRequest request)
        {
            RemoveItemFromCartResponse response = new RemoveItemFromCartResponse();
            var cartItem = await cartItemRepository.GetCartItemByIdAsync(request.CartItemId);

            if (cartItem != null && cartItem.CartId == request.CartId)
            {
                await cartItemRepository.DeleteCartItem(cartItem);
                response.CartItemId = cartItem.Id;
            }
            return response;
        }

        #endregion

        #region Get Cart
        public async Task<Cart> GetCartAsync()
        {
            var UniqueId = await UniqueCartIdAsync();
            var carts = await cartRepository.GetAllAsync();
            return carts.FirstOrDefault(c => c.UniqueCartId == UniqueId);

        }
        #endregion

        #region Fetch Cart
        public async Task<FetchCartResponse> FetchCartAsync()
        {
            FetchCartResponse response = new FetchCartResponse();
            var cart = await GetCartAsync();
            IEnumerable<CartItem> cartItems = new List<CartItem>();

            if (cart != null)
            {
                cartItems = await cartItemRepository.GetCartItemsByCartIdAsync(cart.Id);
            }

            var cartItemsDto = mapper.Map<IEnumerable<CartItemDto>>(cartItems);
            var cartDto = mapper.Map<CartDto>(cart);
            cartDto.CartItems = cartItemsDto;
            response.Cart = cartDto;
            return response;
        }
        #endregion

        #region Get Cart Items
        public async Task<IEnumerable<CartItem>> GetCartItemsAsync()
        {
            IEnumerable<CartItem> cartItems = new List<CartItem>();
            var cart = await GetCartAsync();
            if (cart != null)
            {
                cartItems = await cartItemRepository.GetCartItemsByCartIdAsync(cart.Id);
            }
            return cartItems;
        }
        #endregion

        #region Cart Items Count
        public async Task<int> CartItemCountAsync()
        {
            var count = 0;
            var cartItems = await GetCartItemsAsync();
            foreach (var item in cartItems)
            {
                count += item.Quantity;
            }
            return count;
        }
        #endregion

        #region Cart Total
        public async Task<decimal> GetCartTotalAsync()
        {
            decimal total = 0;
            var cartItems = await GetCartItemsAsync();

            foreach (var item in cartItems)
            {
                var product = await _productRepository.GetByIdAsync(item.ProductId);
                total += item.Quantity * product.Price;
            }
            return total;
        }
        #endregion

        #region Unique Cart ID

        public async Task<string> UniqueCartIdAsync()
        {
            var existingId = _httpContextAccessor.HttpContext.Session.GetString(UniqueCartIdSessionKey);
            if (!string.IsNullOrWhiteSpace(existingId))
            {
                return existingId;
            }
            var uniqueId = Guid.NewGuid().ToString();
            _httpContextAccessor.HttpContext.Session.SetString(UniqueCartIdSessionKey, uniqueId);
            return uniqueId;
        } 
        #endregion
    }
}
