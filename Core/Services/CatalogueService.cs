using AutoMapper;
using Domain.Contrats;
using Domain.Entities.ProductModule;
using ServicesAbstractions;
using Shared.Contracts.Request.Product;
using Shared.Contracts.Response.Product;
using Shared.DTOS.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CatalogueService(IGenericRepository<Product> _genericRepository,IMapper _mapper) : ICatalogueService
    {
        public async Task<FetchProductResponse> FetchProductsAsync(FetchProductRequest fetchProductsRequest)
        {
            IEnumerable<Product> products=new List<Product>();
            int productCount = 0;

            if(fetchProductsRequest.CategorySlug== "all-categories" && fetchProductsRequest.BrandSlug== "all-brands")
            {
                var allProducts =await _genericRepository.GetAllAsync();//kol products
                productCount = allProducts.Count();//عددهم

                products = allProducts
                    .Where(products => products.ProductStatus == ProductStatus.Active)
                    .Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                    .Take(fetchProductsRequest.ProductsPerPage);
            }


            if(fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var allProducts =await _genericRepository.GetAllAsync();
                var filterdProducts = allProducts
                    .Where(p => p.ProductStatus == ProductStatus.Active &&
                    p.Category.Slug == fetchProductsRequest.CategorySlug &&
                    p.Brand.Slug == fetchProductsRequest.BrandSlug);

                productCount = filterdProducts.Count();
                products=filterdProducts
                    .Skip((fetchProductsRequest.PageNumber - 1) *fetchProductsRequest.ProductsPerPage)
                    .Take(fetchProductsRequest.ProductsPerPage);       
            }

            if(fetchProductsRequest.CategorySlug!="all-categories"&&fetchProductsRequest.BrandSlug=="all-brands")
            {
                var allProducts =await _genericRepository.GetAllAsync();
                var filterdProducts = allProducts
                    .Where(p => p.ProductStatus == ProductStatus.Active &&
                    p.Category.Slug == fetchProductsRequest.CategorySlug);
                productCount = filterdProducts.Count();

                products=filterdProducts
                    .Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                    .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var allProducts = await _genericRepository.GetAllAsync();
                var filterdProducts = allProducts
                    .Where(p => p.ProductStatus == ProductStatus.Active &&
                    p.Brand.Slug == fetchProductsRequest.BrandSlug);
                productCount = filterdProducts.Count();

                products = filterdProducts
                    .Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                    .Take(fetchProductsRequest.ProductsPerPage);
            }
            var totalPages=(int)Math.Ceiling((decimal)productCount / fetchProductsRequest.ProductsPerPage);

            int[] pages = Enumerable.Range(1, totalPages).ToArray();

            var productsDto=_mapper.Map<IEnumerable<ProductDto>>(products);

            return new FetchProductResponse
            {
                Products = productsDto,
                ProductsPerPage = fetchProductsRequest.ProductsPerPage,
                Pages = pages,
                HasNextPages=fetchProductsRequest.PageNumber<totalPages,
                HasPreviousPages=fetchProductsRequest.PageNumber>1,
                CurrentPage=fetchProductsRequest.PageNumber,
                StatusCode=HttpStatusCode.OK
            };
        }            

        
    }
}
