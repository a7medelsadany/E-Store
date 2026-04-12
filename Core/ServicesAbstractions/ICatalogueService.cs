using Shared.Contracts.Request.Product;
using Shared.Contracts.Response.Product;

namespace ServicesAbstractions
{
    public interface ICatalogueService
    {
       public Task<FetchProductResponse> FetchProductsAsync(FetchProductRequest fetchProductsRequest);
    }
}
