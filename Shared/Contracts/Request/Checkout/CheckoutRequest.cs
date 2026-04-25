using Domain.Entities.Order;
using Shared.DTOS.AddressDtos;
using Shared.DTOS.CartDtos;
using Shared.DTOS.CustomerDtos;
using System.ComponentModel.DataAnnotations;

namespace Shared.Contracts.Request.Checkout
{
    public class CheckoutRequest
    {
        public long CustomerId { get; set; }
        public long AddressId { get; set; }
        [Required]
        public string UniqueCartId { get; set; }=string.Empty;
        public PaymentMethod PaymentMethod { get; set; }
    }
}
