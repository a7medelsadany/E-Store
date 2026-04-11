using Services;

namespace E_Store.Extentions
{
    public static class CoreServiceExtentions
    {
        public static IServiceCollection AddCoreService(this IServiceCollection services)
        {
            services.AddAutoMapper(x=>x.AddProfile(new MappingProfiles()));


            return services;
        }
    }
}
