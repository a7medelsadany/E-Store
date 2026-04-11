using Shared.DTOS.ProductDtos;

namespace Shared.Contracts.Response.Category
{
    public class FetchCategoryResponse: ResponseBase
    {
        public int CategoiresPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<CategoryDto> Categories { get; set; }
    }
}
