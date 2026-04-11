using AutoMapper;
using Domain.Contrats;
using Domain.Entities.ProductModule;
using ServicesAbstractions;
using Shared.Contracts.Request.Category;
using Shared.Contracts.Response.Category;
using Shared.DTOS.ProductDtos;
using System.Net;

namespace Services
{
    public class CategoryService(IGenericRepository<Category> _genericRepository, IMapper _mapper) : ICategoryService
    {
        #region Create Category
        public async Task<CreateCategoryResponse> SaveCategoryAsync(CreateCategoryRequest categoryRequest)
        {
            var response = new CreateCategoryResponse();

            if (categoryRequest == null || categoryRequest.Category == null)
            {
                response.Messages.Add("Invavlid category data!!");
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }


            var categoryEntity = _mapper.Map<Category>(categoryRequest.Category);
            try
            {
                await _genericRepository.SaveAsync(categoryEntity);
                await _genericRepository.SaveChangesAsync();
                response.Category = _mapper.Map<CategoryDto>(categoryEntity);
                response.Messages.Add("Category created successfully");
                response.StatusCode = HttpStatusCode.Created;
            }
            catch (Exception ex)
            {
                response.Messages.Add($"An error occurred while creating the category: {ex.Message}");
                response.StatusCode = HttpStatusCode.InternalServerError;
            }
            return response;

        }
        #endregion

        #region Get Category
        public async Task<GetCategoryResponse> GetCategoryAsync(GetCategoryRequest getCategoryRequest)
        {
            if (getCategoryRequest == null || getCategoryRequest.Id <= 0)
                throw new ArgumentNullException("Invalid category ID");

            var categoryEntity = await _genericRepository.GetByIdAsync(getCategoryRequest.Id);

            if (categoryEntity == null)
                throw new KeyNotFoundException("Category not found");


            return new GetCategoryResponse
            {
                Category = _mapper.Map<CategoryDto>(categoryEntity),
                Messages = new List<string> { "Category retrieved successfully" },
                StatusCode = HttpStatusCode.OK
            };
        }
        #endregion

        #region Get Categories

        public async Task<FetchCategoryResponse> GetCategoriesAsync(FetchCategoryRequest fetchCategoriesRequest)
        {
            var Categories = await _genericRepository.GetAllAsync();

            var categoriesDtos = _mapper.Map<IEnumerable<CategoryDto>>(Categories ?? Enumerable.Empty<Category>());
            return new FetchCategoryResponse
            {
                Categories = categoriesDtos,
                Messages = new List<string> { "Categories retrieved successfully" },
                StatusCode = HttpStatusCode.OK
            };
        }
        #endregion

        #region Delete Category
        public async Task<DeleteCategoryResponse> DeleteCategoryAsync(DeleteCategoryRequest deleteCategoryRequest)
        {
            var categoryEntity = await _genericRepository.GetByIdAsync(deleteCategoryRequest.Id);

            if (categoryEntity == null)
                throw new KeyNotFoundException("Category not found");

            _genericRepository.Remove(categoryEntity);
            await _genericRepository.SaveChangesAsync();

            return new DeleteCategoryResponse
            {
                Messages = new List<string> { "Category deleted successfully" },
                StatusCode = HttpStatusCode.OK
            };
        } 
        #endregion

        #region Update Category
        public async Task<UpdateCategoryResponse> EditCategoryAsync(UpdateCategoryRequest updateCategoryRequest)
        {
            if (updateCategoryRequest == null || updateCategoryRequest.Category == null)
                throw new ArgumentNullException("Invalid data");

            if (updateCategoryRequest.Id != updateCategoryRequest.Category.Id)
                throw new ArgumentException("ID mismatch");

            var existingCategory = await _genericRepository.GetByIdAsync(updateCategoryRequest.Id);

            if (existingCategory == null)
                throw new KeyNotFoundException("Category not found");

            _mapper.Map(updateCategoryRequest.Category, existingCategory);
            _genericRepository.Update(existingCategory);
            await _genericRepository.SaveChangesAsync();

            return new UpdateCategoryResponse
            {
                Category = _mapper.Map<CategoryDto>(existingCategory),
                Messages = new List<string> { "Category updated successfully" },
                StatusCode = HttpStatusCode.OK
            };

        } 
        #endregion

    }
}
