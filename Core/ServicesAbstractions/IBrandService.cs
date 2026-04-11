using Shared.Contracts.Request.Brand;
using Shared.Contracts.Response.Brand;

namespace ServicesAbstractions
{
    public interface IBrandService
    {
        public Task<CreateBrandResponse> SaveBrandAsync(CreateBrandRequest brandRequest);
        public Task<UpdateBrandResponse> EditBrandAsync(UpdateBrandRequest updateBrandRequest);
        public Task<GetBrandResponse> GetBrandAsync(GetBrandRequest getBrandRequest);
        public Task<FetchBrandResponse> GetBrandsAsync(FetchBrandRequest fetchBrandsRequest);
        public Task<DeleteBrandResponse> DeleteBrandAsync(DeleteBrandRequest deleteBrandRequest);
    }
}
