using AutoMapper;
using Domain.Contrats;
using ServicesAbstractions;
using Shared.Contracts.Request.Order;
using Shared.Contracts.Response.Order;
using Shared.DTOS.OrderDtos;
using System.Net;

namespace Services
{
    public class OrderService(IOrderRepository orderRepository, IMapper mapper) : IOrderService
    {
        #region Get Order
        public async Task<GetOrderResponse> GetOrderAsync(GetOrderRequest request)
        {
            var response = new GetOrderResponse();

            if (request == null || request.Id <= 0)
            {
                response.Messages.Add("Invalid order ID..");
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }

            var order = await orderRepository.GetOrderByIdAsync(request.Id);

            if (order == null)
            {
                response.Messages.Add("Order not found..");
                response.StatusCode = HttpStatusCode.NotFound;
                return response;
            }

            response.Order = mapper.Map<OrderDto>(order);
            response.StatusCode = HttpStatusCode.OK;
            return response;
        }
        #endregion

        #region Get All Orders
        public async Task<FetchOrdersResponse> GetOrdersAsync(FetchOrderRequest request)
        {
            var response = new FetchOrdersResponse();

            var orders = await orderRepository.GetAllOrdersAsync();

            var TotalOrders = orders.Count();
            var TotalPages = (int)Math.Ceiling((decimal)TotalOrders / request.OrdersPerPage);

            var PagedOrders = orders
                .Take((request.PageNumber - 1) * request.OrdersPerPage)
                .Skip(request.OrdersPerPage);

            response.Orders = mapper.Map<IEnumerable<OrderDto>>(PagedOrders);
            response.CurrentPage = request.PageNumber;
            response.HasNextPages = request.PageNumber < TotalPages;
            response.OrdersPerPage = request.OrdersPerPage;
            response.Pages = Enumerable.Range(1, TotalPages).ToArray();
            response.HasPreviousPages = request.PageNumber > 1;
            response.StatusCode = HttpStatusCode.OK;
            return response;
        } 
        #endregion
    }
}
