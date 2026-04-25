using AutoMapper;
using Domain.Contrats;
using Domain.Entities.ProductModule;
using Microsoft.AspNetCore.Http;
using ServicesAbstractions;

namespace Services
{
    public class ServiceManager(IGenericRepository<Product> productRepository,
        IGenericRepository<Category> categoryRepository,
        IGenericRepository<Brand> brandRepository,
        IOrderRepository orderRepository,
        ICatalogueService catalogueService,
        IOrderItemRepository orderItemRepository,
        ICartRepository cartRepository,
        ICartItemRepository cartItemRepository,
        IHttpContextAccessor httpContextAccessor,
        IMapper mapper) : IServiceManager
    {
        private readonly Lazy<IProductService> _LazyProductService = new Lazy<IProductService>(() => new ProductService(productRepository, catalogueService, mapper));
        private readonly Lazy<ICategoryService> _LazyCategoryService = new Lazy<ICategoryService>(() => new CategoryService(categoryRepository, mapper));
        private readonly Lazy<IBrandService> _LazyBrandService = new Lazy<IBrandService>(() => new BrandService(brandRepository, mapper));
        private readonly Lazy<ICatalogueService> _LazyCatalogueService = new Lazy<ICatalogueService>(() => new CatalogueService(productRepository, mapper));
        private readonly Lazy<ICartService> _LazyCartService = new Lazy<ICartService>(() => new CartService(httpContextAccessor, cartRepository, cartItemRepository, productRepository, mapper));
        private readonly Lazy<IOrderService> _LazyOrderService = new Lazy<IOrderService>(() => new OrderService(orderRepository,mapper));
        private readonly Lazy<ICheckoutService> _LazyCheckoutService=new Lazy<ICheckoutService>(()=>new CheckoutService(orderRepository,cartRepository,orderItemRepository,cartItemRepository,mapper));

        public IProductService ProductService => _LazyProductService.Value;

        public ICategoryService CategoryService => _LazyCategoryService.Value;

        public IBrandService BrandService => _LazyBrandService.Value;

        public ICatalogueService CatalogueService => _LazyCatalogueService.Value;

        public ICartService CartService => _LazyCartService.Value;

        public IOrderService orderService =>_LazyOrderService.Value;

        public ICheckoutService checkoutService => _LazyCheckoutService.Value;

    }
}
