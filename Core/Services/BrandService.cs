using System.Net;
using AutoMapper;
using Domain.Contrats;
using Domain.Entities.ProductModule;
using ServicesAbstractions;
using Shared.Contracts.Request.Brand;
using Shared.Contracts.Response.Brand;
using Shared.DTOS.ProductDtos;

namespace Services
{
    public class BrandService(IGenericRepository<Brand> _genericRepository, IMapper _mapper) : IBrandService
    {
        #region Create Brand /Save
        public async Task<CreateBrandResponse> SaveBrandAsync(CreateBrandRequest brandRequest)
        {
            var response = new CreateBrandResponse();
            var brandEntity = _mapper.Map<Brand>(brandRequest.Brand);
            try
            {
                await _genericRepository.SaveAsync(brandEntity);
                await _genericRepository.SaveChangesAsync();
                response.Brand = _mapper.Map<BrandDto>(brandEntity);
                response.Messages.Add("Brand created successfully.");
                response.StatusCode = HttpStatusCode.Created;
            }
            catch (Exception ex)
            {
                response.Messages.Add(ex.Message);
                response.StatusCode = HttpStatusCode.InternalServerError;
            }
            return response;
        }
        #endregion


        #region Update Brand
        public async Task<UpdateBrandResponse> EditBrandAsync(UpdateBrandRequest updateBrandRequest)
        {
            if (updateBrandRequest == null || updateBrandRequest.Brand == null)
                throw new ArgumentNullException("Invalid data");

            if (updateBrandRequest.Id != updateBrandRequest.Brand.Id)
                throw new ArgumentException("Mismatched brand ID");

            var existingBrand = await _genericRepository.GetByIdAsync(updateBrandRequest.Id);
            if (existingBrand == null)
                throw new KeyNotFoundException("Brand not found");

            _mapper.Map(updateBrandRequest.Brand, existingBrand);
            _genericRepository.Update(existingBrand);
            await _genericRepository.SaveChangesAsync();

            return new UpdateBrandResponse
            {
                Brand = _mapper.Map<BrandDto>(existingBrand),
                Messages = new List<string> { "Brand updated successfully." },
                StatusCode = HttpStatusCode.OK
            };
        

        }
        #endregion


        #region Get Brand
        public async Task<GetBrandResponse> GetBrandAsync(GetBrandRequest getBrandRequest)
        {

            if (getBrandRequest == null || getBrandRequest.Id <= 0)
                throw new ArgumentNullException("Invalid brand ID");

            var brandEntity = await _genericRepository.GetByIdAsync(getBrandRequest.Id);

            if (brandEntity == null)
                throw new KeyNotFoundException($"Brand with id {getBrandRequest.Id} not found");
            

            return new GetBrandResponse
            {
                Brand = _mapper.Map<BrandDto>(brandEntity),
                StatusCode= HttpStatusCode.OK

            };
        }
        #endregion


        #region Delete Brand
        public async Task<DeleteBrandResponse> DeleteBrandAsync(DeleteBrandRequest deleteBrandRequest)
        {
            var brand = await _genericRepository.GetByIdAsync(deleteBrandRequest.Id);

            if (brand == null)
                throw new KeyNotFoundException("Brand not found");

            _genericRepository.Remove(brand);
            await _genericRepository.SaveChangesAsync();
            return new DeleteBrandResponse
            {
                Messages = new List<string> { "Brand deleted successfully." },
                StatusCode = HttpStatusCode.OK
            };
        }

        #endregion


        #region Get Brands
        public async Task<FetchBrandResponse> GetBrandsAsync(FetchBrandRequest fetchBrandsRequest)
        {
            var brands = await _genericRepository.GetAllAsync();

            var brandDtos = _mapper.Map<IEnumerable<BrandDto>>(brands ?? Enumerable.Empty<Brand>());
            return new FetchBrandResponse
            {
                Brands = brandDtos,
                StatusCode = HttpStatusCode.OK

            };
        } 
        #endregion

    }
}
