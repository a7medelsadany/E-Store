using Shared.DTOS.OrderDtos;

namespace Shared.Contracts.Response.Order
{
    public class GetOrderResponse:ResponseBase
    {
        public OrderDto Order { get; set; }
    }
}
