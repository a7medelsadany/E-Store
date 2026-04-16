using Microsoft.AspNetCore.Mvc;
using ServicesAbstractions;
using Shared.Contracts.Request.Product;
using Shared.Contracts.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    public class ProductController(IServiceManager _serviceManager):APIBaseController
    {
        #region Get Products
        [HttpGet]
        public async Task<ActionResult<FetchProductResponse>> GetProducts([FromQuery] FetchProductRequest fetchProductRequest)
        {
            try
            {
                var response = await _serviceManager.ProductService.GetProductsAsync(fetchProductRequest);
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

        #region Get Product by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<GetProductResponse>> GetProduct([FromRoute] int id)
        {
            try
            {
                var request = new GetProductRequest { Id = id };
                var response = await _serviceManager.ProductService.GetProductAsync(request);
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

        #region Create Product
        [HttpPost]
        public async Task<ActionResult<CreateProductResponse>> CreateProduct([FromBody] CreateProductRequest createProductRequest)
        {
            try
            {
                var response = await _serviceManager.ProductService.SaveProductAsync(createProductRequest);
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

        #region Update Product
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateProductResponse>> UpdateProduct([FromRoute] int id, [FromQuery] UpdateProductRequest updateProductRequest)
        {
            try
            {
                if (id != updateProductRequest.Id)
                    return BadRequest("Mismatch Product id.");
                var response = await _serviceManager.ProductService.EditProductAsync(updateProductRequest);
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

        #region Delete Product
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteProductResponse>> DeleteProduct([FromRoute] int id)
        {
            try
            {
                var request = new DeleteProductRequest { Id = id };
                var response = await _serviceManager.ProductService.DeleteProductAsync(request);
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
        #endregion
    }
}
