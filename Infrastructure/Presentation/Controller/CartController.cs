using Microsoft.AspNetCore.Mvc;
using ServicesAbstractions;
using Shared.Contracts.Request.Cart;
using Shared.Contracts.Response.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    public class CartController(IServiceManager serviceManager):APIBaseController
    {
        #region Get Cart

        [HttpGet]
        public async Task<ActionResult<FetchCartResponse>> GetCart()
        {
            try
            {
                var response = await serviceManager.CartService.FetchCartAsync();
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

        #region Add Item To Cart
        [HttpPost]
        public async Task<ActionResult<AddItemToCartResponse>> AddItemToCart([FromBody] AddItemToCartRequest request)
        {
            try
            {
                var response = await serviceManager.CartService.AddItemToCartAsync(request);
                return Ok(response);
            }
            catch(KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        #endregion

        [HttpDelete("{CartId}/{CartItemId}")]
        public async Task<ActionResult<RemoveItemFromCartResponse>> RemoveItemFromCart([FromRoute] long CartId,[FromRoute] long CartItemId)
        {
            try
            {
                var RemoveItemFromCart = new RemoveItemFromCartRequest { CartId = CartId, CartItemId = CartItemId };
                var response = await serviceManager.CartService.RemoveItemFromCartAsync(RemoveItemFromCart);
                return NoContent();
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
