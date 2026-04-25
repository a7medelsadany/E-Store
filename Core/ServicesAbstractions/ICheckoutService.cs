using Shared.Contracts.Request.Checkout;
using Shared.Contracts.Response.Checkout;

namespace ServicesAbstractions
{
    public interface ICheckoutService
    {
        Task<CheckoutResponse> ProcessCheckoutAsync(CheckoutRequest request);
    }
}
