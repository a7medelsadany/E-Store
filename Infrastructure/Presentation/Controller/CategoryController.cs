using Microsoft.AspNetCore.Mvc;
using ServicesAbstractions;
using Shared.Contracts.Request.Category;
using Shared.Contracts.Response.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controller
{
    public class CategoryController(IServiceManager _serviceManager) : APIBaseController
    {
        #region Get Categories
        [HttpGet]
        public async Task<ActionResult<FetchCategoryResponse>> GetCategoires([FromQuery] FetchCategoryRequest fetchCategoryRequest)
        {
            try
            {
                var response = await _serviceManager.CategoryService.GetCategoriesAsync(fetchCategoryRequest);
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

        #region Get Category
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCategoryResponse>> GetCategory([FromRoute] int id)
        {
            try
            {
                var request = new GetCategoryRequest { Id = id };
                var response = await _serviceManager.CategoryService.GetCategoryAsync(request);
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

        #region Create Category
        [HttpPost]
        public async Task<ActionResult<CreateCategoryResponse>> CreateCategory([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            try
            {
                var response = await _serviceManager.CategoryService.SaveCategoryAsync(createCategoryRequest);
                return Ok(response);
                //return CreatedAtAction(nameof(GetCategory), new { id = response.Category.Id }, response);
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

        #region Update Category
        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateCategoryResponse>> UpdateCategory([FromRoute] int id, [FromBody] UpdateCategoryRequest updateCategoryRequest)
        {
            try
            {
                if (id != updateCategoryRequest.Id)
                    return BadRequest("MisMatch Category Id.");
                var response = await _serviceManager.CategoryService.EditCategoryAsync(updateCategoryRequest);
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

        #region Delete Category
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteCategoryResponse>> DeleteCategory([FromRoute] int id)
        {
            try
            {
                var request = new DeleteCategoryRequest { Id = id };
                var response = await _serviceManager.CategoryService.DeleteCategoryAsync(request);
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
