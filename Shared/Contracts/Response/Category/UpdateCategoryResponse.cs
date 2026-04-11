using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Category
{
    public  class UpdateCategoryResponse:ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
