using AutoMapper;
using Domain.Contrats;
using Domain.Entities.ProductModule;
using ServicesAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceManager(IGenericRepository<Product> productRepository,
        IGenericRepository<Category> categoryRepository,
        IGenericRepository<Brand> brandRepository,
        ICatalogueService catalogueService,
        IMapper mapper) : IServiceManager
    {
        private readonly Lazy<IProductService> _LazyProductService=new Lazy<IProductService>(()=>new ProductService(productRepository,catalogueService,mapper));
        private readonly Lazy<ICategoryService> _LazyCategoryService = new Lazy<ICategoryService>(() => new CategoryService(categoryRepository, mapper));
        private readonly Lazy<IBrandService> _LazyBrandService = new Lazy<IBrandService>(() => new BrandService(brandRepository,mapper));
        private readonly Lazy<ICatalogueService> _LazyCatalogueService = new Lazy<ICatalogueService>(() => new CatalogueService(productRepository,mapper));

        public IProductService ProductService => _LazyProductService.Value;

        public ICategoryService CategoryService => _LazyCategoryService.Value;

        public IBrandService BrandService => _LazyBrandService.Value;

        public ICatalogueService CatalogueService => _LazyCatalogueService.Value;
    }
}
