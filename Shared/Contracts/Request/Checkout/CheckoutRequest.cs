using Domain.Entities.Order;
using Shared.DTOS.AddressDtos;
using Shared.DTOS.CartDtos;
using Shared.DTOS.CustomerDtos;

namespace Shared.Contracts.Request.Checkout
{
    public class CheckoutRequest
    {
        public CustomerDto Customer { get; set; }
        public AddressDto  Address { get; set; }
        public CartDto Cart { get; set; }
        public PaymentMethod paymentMethod { get; set; }
    }
}
