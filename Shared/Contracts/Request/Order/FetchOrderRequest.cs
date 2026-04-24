namespace Shared.Contracts.Request.Order
{
    public class FetchOrderRequest
    {
        public int PageNumber { get; set; }
        public int OrdersPerPage { get; set; }
    }
}
