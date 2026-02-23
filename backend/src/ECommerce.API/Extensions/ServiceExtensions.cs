using ECommerce.API.Mappings;
using ECommerce.API.Repositories.Implementations;
using ECommerce.API.Repositories.Interfaces;
using ECommerce.API.Services.Implementations;
using ECommerce.API.Services.Interfaces;

namespace ECommerce.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //AutoMapper
            services.AddAutoMapper(typeof(ProductMappingProfile));

            //Repositories
            services.AddScoped<IProductRepository, ProductRepository>();

            //Services
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}
