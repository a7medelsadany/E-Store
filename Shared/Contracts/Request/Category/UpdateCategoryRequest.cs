using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Request.Category
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }
        public CategoryDto Category { get; set; }
    }
}
