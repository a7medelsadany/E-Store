using Shared.Contracts.Request.Product;
using Shared.Contracts.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesAbstractions
{
    public interface IProductService
    {
        public Task<CreateProductResponse> SaveProductAsync(CreateProductRequest productRequest);
        public  Task<UpdateProductResponse> EditProductAsync(UpdateProductRequest updateProductRequest);
        public Task<GetProductResponse> GetProductAsync(GetProductRequest getProductRequest);
        public Task<FetchProductResponse> GetProductsAsync(FetchProductRequest fetchProductsRequest);
        public Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest deleteProductRequest);
    }
}
