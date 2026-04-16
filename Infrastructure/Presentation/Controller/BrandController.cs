using Microsoft.AspNetCore.Mvc;
using ServicesAbstractions;
using Shared.Contracts.Request.Brand;
using Shared.Contracts.Response.Brand;

namespace Presentation.Controller
{
    public class BrandController(IServiceManager _serviceManager) : APIBaseController
    {
        #region Get Brands
        [HttpGet]
        public async Task<ActionResult<FetchBrandResponse>> GetBrands([FromQuery] FetchBrandRequest fetchBrandRequest)
        {
            try
            {
                var response = await _serviceManager.BrandService.GetBrandsAsync(fetchBrandRequest);
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

        #region Get Brand by Id
        [HttpGet("{id}")]
   

        public async Task<ActionResult<GetBrandResponse>> GetBrand([FromRoute] int id)
        {
            try
            {
                var request = new GetBrandRequest { Id = id };
                var response = await _serviceManager.BrandService.GetBrandAsync(request);
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

        #region Create Brand
        [HttpPost]
        public async Task<ActionResult<CreateBrandResponse>> CreateBrand([FromBody] CreateBrandRequest createBrandRequest)
        {
            try
            {
                var response = await _serviceManager.BrandService.SaveBrandAsync(createBrandRequest);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }
        #endregion

        #region Update Brand
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateBrandResponse>> UpdateBrand([FromRoute] int id, [FromBody] UpdateBrandRequest updateBrandRequest)
        {
            try
            {
                if (id != updateBrandRequest.Id)
                    return BadRequest("Mismatched brand ID");
                var response = await _serviceManager.BrandService.EditBrandAsync(updateBrandRequest);
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

        #region Delete Brand
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBrand([FromRoute] int id)
        {
            try
            {
                var request = new DeleteBrandRequest { Id = id };
                await _serviceManager.BrandService.DeleteBrandAsync(request);
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
