using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Category
{
    public class DeleteCategoryResponse: ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
