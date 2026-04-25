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

            //validate Request
            if (request == null || request.Cart == null || request.Customer == null)
            {
                response.Messages.Add("Invalid checkout request.");
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var OrderItemTotal = request.Cart.CartItems
                .Sum(ci => ci.Product.Price * ci.Quantity);

            var ShippingCharge = OrderItemTotal > 500 ? 0 : 20;

            var OrderTotal = OrderItemTotal + ShippingCharge;

            var order = new Order
            {
                CustomerId= request.Customer.Id,
                AddressId= request.Address.Id,
                OrderItemTotal=OrderItemTotal,
                ShippingCharge=ShippingCharge,
                OrderTotal=OrderTotal,
                PaymentMethod = request.paymentMethod,
                OrderStatus = OrderStatus.Pending,
                CreateDate= DateTimeOffset.UtcNow,
                ModifiedDate= DateTimeOffset.UtcNow
            };

            await orderRepository.AddOrderAsync(order);

            var orderItems = request.Cart.CartItems.Select(ci=>new OrderItem
            {
                OrderId=order.Id,
                ProductId=ci.ProductId,
                Quantity=ci.Quantity,
                CreateDate = DateTimeOffset.UtcNow,
                ModifiedDate= DateTimeOffset.UtcNow
            }).ToList();

            foreach (var item in orderItems)
                await itemRepository.AddOrderItemAsync(item);

            var cart = await cartRepository.GetCartByUniqueIdAsync(request.Cart.UniqueCartId);
            if(cart != null)
            {
                var cartItems = await cartItemRepository
                    .GetCartItemsByCartIdAsync(cart.Id);

                foreach (var item in cartItems)
                    await cartItemRepository.DeleteCartItem(item);
            }
            response.Messages.Add("Order Placed successfully.");
            response.StatusCode=HttpStatusCode.Created;
            return response;
        }
    }
}
