using Shared.Contracts.Request.Category;
using Shared.Contracts.Response.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAbstractions
{
    public interface ICategoryService
    {
        public Task<CreateCategoryResponse> SaveCategoryAsync(CreateCategoryRequest categoryRequest);
        public Task<UpdateCategoryResponse> EditCategoryAsync(UpdateCategoryRequest updateCategoryRequest);
        public Task<GetCategoryResponse> GetCategoryAsync(GetCategoryRequest getCategoryRequest);
        public Task<FetchCategoryResponse> GetCategoriesAsync(FetchCategoryRequest fetchCategoriesRequest);
        public Task<DeleteCategoryResponse> DeleteCategoryAsync(DeleteCategoryRequest deleteCategoryRequest);
    }
}
