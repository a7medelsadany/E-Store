using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Category
{
    public class GetCategoryResponse:ResponseBase
    {
        public CategoryDto Category { get; set; }
    }
}
