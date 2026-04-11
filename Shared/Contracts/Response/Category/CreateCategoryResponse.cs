using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Category
{
    public class CreateCategoryResponse:ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
