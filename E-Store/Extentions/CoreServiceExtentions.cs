using Domain.Contrats;
using Domain.Entities.ProductModule;
using Persistance.Repositories;
using Services;
using ServicesAbstractions;

namespace E_Store.Extentions
{
    public static class CoreServiceExtentions
    {
        public static IServiceCollection AddCoreService(this IServiceCollection services)
        {
            services.AddAutoMapper(x=>x.AddProfile(new MappingProfiles()));
            //------------------------------------------------------------------------------
            services.AddScoped<IServiceManager, ServiceManager>();
            //------------------------------------------------------------------------------
            services.AddScoped<IGenericRepository<Product>,GenericRepository<Product>>();
            services.AddScoped<IGenericRepository<Category>,GenericRepository<Category>>();
            services.AddScoped<IGenericRepository<Brand>,GenericRepository<Brand>>();

            return services;
        }
    }
}
