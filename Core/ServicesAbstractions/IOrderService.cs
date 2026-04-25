using Shared.Contracts.Request.Order;
using Shared.Contracts.Response.Order;

namespace ServicesAbstractions
{
    public interface IOrderService
    {
        Task<GetOrderResponse> GetOrderAsync(GetOrderRequest request);
        Task<FetchOrdersResponse> GetOrdersAsync(FetchOrderRequest request);
    }
}
