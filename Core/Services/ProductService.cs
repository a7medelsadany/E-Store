using AutoMapper;
using Domain.Contrats;
using Domain.Entities.ProductModule;
using ServicesAbstractions;
using Shared.Contracts.Request.Product;
using Shared.Contracts.Response.Product;
using Shared.DTOS.ProductDtos;
using System.Net;

namespace Services
{
    public class ProductService(IGenericRepository<Product> _genericRepository, ICatalogueService _catalogueService, IMapper _mapper) : IProductService
    {
        #region Delete Product
        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest deleteProductRequest)
        {
            var product = await _genericRepository.GetByIdAsync(deleteProductRequest.Id);
            if (product is null)
                throw new KeyNotFoundException($"Product with id {deleteProductRequest.Id} not found");

            _genericRepository.Remove(product);
            await _genericRepository.SaveChangesAsync();
            return new DeleteProductResponse
            {
                Product = _mapper.Map<ProductDto>(product),
                Messages = new List<string> { "Product deleted successfully" },
                StatusCode = HttpStatusCode.OK
            };
        }
        #endregion

        #region Update Product
        public async Task<UpdateProductResponse> EditProductAsync(UpdateProductRequest updateProductRequest)
        {
            var product = await _genericRepository.GetByIdAsync(updateProductRequest.Id);
            if (product is null)
                throw new KeyNotFoundException($"Product with id {updateProductRequest.Id} not found");

            if (updateProductRequest.Id != updateProductRequest.Product.Id)
                throw new ArgumentException("Product id mismatch");

            _mapper.Map(updateProductRequest.Product, product);
            _genericRepository.Update(product);
            await _genericRepository.SaveChangesAsync();

            return new UpdateProductResponse
            {
                Product = _mapper.Map<ProductDto>(product),
                Messages = new List<string> { "Product updated successfully" },
                StatusCode = HttpStatusCode.OK
            };
        }
        #endregion

        #region Get Product
        public async Task<GetProductResponse> GetProductAsync(GetProductRequest getProductRequest)
        {
            if (getProductRequest == null || getProductRequest.Id <= 0)
                throw new ArgumentNullException("Invalid product id");

            var product = await _genericRepository.GetByIdAsync(getProductRequest.Id);

            if (product is null)
                throw new KeyNotFoundException($"Product with id {getProductRequest.Id} not found");

            return new GetProductResponse
            {
                Product = _mapper.Map<ProductDto>(product),
                Messages = new List<string> { "Product retrieved successfully" },
                StatusCode = HttpStatusCode.OK
            };
        }
        #endregion

        #region Create Product
        public async Task<CreateProductResponse> SaveProductAsync(CreateProductRequest productRequest)
        {
            var response = new CreateProductResponse();
            if (productRequest == null || productRequest.Product == null)
            {
                response.Messages = new List<string> { "Invalid product data" };
                response.StatusCode = HttpStatusCode.BadRequest;
                return response;
            }
            var product = _mapper.Map<Product>(productRequest.Product);
            try
            {
                await _genericRepository.SaveAsync(product);
                await _genericRepository.SaveChangesAsync();
                response.Product = _mapper.Map<ProductDto>(product);
                response.Messages = new List<string> { "Product created successfully" };
                response.StatusCode = HttpStatusCode.Created;
            }
            catch (Exception ex)
            {
                response.Messages = new List<string> { $"An error occurred while creating the product: {ex.Message}" };
                response.StatusCode = HttpStatusCode.InternalServerError;

            }
            return response;
        }

        #endregion

        #region Get Products
        public async Task<FetchProductResponse> GetProductsAsync(FetchProductRequest fetchProductsRequest)
        {
            return await _catalogueService.FetchProductsAsync(fetchProductsRequest);
        } 
        #endregion

    } 
}
