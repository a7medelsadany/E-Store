using AutoMapper;
using Domain.Contrats;
using Domain.Entities.Order;
using ServicesAbstractions;
using Shared.Contracts.Request.Checkout;
using Shared.Contracts.Response.Checkout;
using System.Net;

namespace Services
{
    public class CheckoutService(IOrderRepository orderRepository,
        ICartRepository cartRepository,
        IOrderItemRepository itemRepository,
        ICartItemRepository cartItemRepository,
        IMapper mapper) : ICheckoutService
    {
        public async Task<CheckoutResponse> ProcessCheckoutAsync(CheckoutRequest request)
        {
            var response = new CheckoutResponse();

            // 1️⃣ جيب الـ Cart من الـ Database
            var cart = await cartRepository.GetCartByUniqueIdAsync(request.UniqueCartId);
            if (cart == null)
            {
                response.Messages.Add("Cart not found.");
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            // 2️⃣ جيب الـ CartItems
            var cartItems = await cartItemRepository
                .GetCartItemsByCartIdAsync(cart.Id);
            if (!cartItems.Any())
            {
                response.Messages.Add("Cart is empty.");
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            // 3️⃣ حساب الأسعار
            var orderItemTotal = cartItems
                .Sum(ci => ci.Product.Price * ci.Quantity);
            var shippingCharge = orderItemTotal > 500 ? 0 : 20;
            var orderTotal = orderItemTotal + shippingCharge;

            // 4️⃣ عمل الـ Order
            var order = new Order
            {
                CustomerId = request.CustomerId,
                AddressId = request.AddressId,
                OrderItemTotal = orderItemTotal,
                ShippingCharge = shippingCharge,
                OrderTotal = orderTotal,
                OrderStatus = OrderStatus.Pending,
                PaymentMethod = request.PaymentMethod,
                CreateDate = DateTimeOffset.UtcNow,
                ModifiedDate = DateTimeOffset.UtcNow
            };
            await orderRepository.AddOrderAsync(order);

            // 5️⃣ عمل الـ OrderItems
            var orderItems = cartItems.Select(ci => new OrderItem
            {
                OrderId = order.Id,
                ProductId = ci.ProductId,
                Quantity = ci.Quantity,
                CreateDate = DateTimeOffset.UtcNow,
                ModifiedDate = DateTimeOffset.UtcNow
            }).ToList();

            foreach (var item in orderItems)
                await itemRepository.AddOrderItemAsync(item);

            // 6️⃣ مسح الـ CartItems بعد الـ Checkout
            foreach (var item in cartItems)
                await cartItemRepository.DeleteCartItem(item);

            response.Messages.Add("Order placed successfully.");
            response.StatusCode = HttpStatusCode.Created;
            return response;
        }
    }
}
