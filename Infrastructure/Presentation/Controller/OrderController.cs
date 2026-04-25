using Microsoft.AspNetCore.Mvc;
using ServicesAbstractions;
using Shared.Contracts.Request.Order;
using Shared.Contracts.Response.Order;

namespace Presentation.Controller
{
    public class OrderController(IServiceManager serviceManager):APIBaseController
    {
        #region Get Order By Id
        [HttpGet("{id}")]
        public async Task<ActionResult<GetOrderResponse>> GetOrder([FromRoute] long id)
        {
            try
            {
                var request = new GetOrderRequest { Id = id };
                var response = await serviceManager.orderService.GetOrderAsync(request);
                return Ok(response);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        #endregion

        #region Get Orders
        [HttpGet]
        public async Task<ActionResult<FetchOrdersResponse>> GetOrders([FromQuery] FetchOrderRequest Request)
        {
            try
            {
                var response = await serviceManager.orderService.GetOrdersAsync(Request);
                return Ok(response);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        } 
        #endregion
    }
}
