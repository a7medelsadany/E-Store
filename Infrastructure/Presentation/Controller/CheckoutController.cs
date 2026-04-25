using Microsoft.AspNetCore.Mvc;
using ServicesAbstractions;
using Shared.Contracts.Request.Checkout;
using Shared.Contracts.Response.Checkout;

namespace Presentation.Controller
{
    public class CheckoutController(IServiceManager serviceManager) : APIBaseController
    {
        [HttpPost]
        public async Task<ActionResult<CheckoutResponse>> ProcessCheckout([FromQuery] CheckoutRequest request)
        {
            try
            {
                if (request == null)
                {
                    return BadRequest("Invalid request.");
                }
                var response = await serviceManager.checkoutService.ProcessCheckoutAsync(request);
                return StatusCode(201, response);
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
    }
}
