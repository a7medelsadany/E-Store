namespace ServicesAbstractions
{
    public interface IServiceManager
    {
        public IProductService ProductService { get; }
        public ICategoryService CategoryService { get; }
        public IBrandService BrandService { get; }
        public ICatalogueService CatalogueService { get; }
        public ICartService CartService { get; }
    }
}
