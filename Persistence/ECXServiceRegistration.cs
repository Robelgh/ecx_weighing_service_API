using Application.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repository;

namespace Persistence
{
    public static partial class ECXServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ECXDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("ECXWeighConnectionString")));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAgriculturalRepository,AgriculturalRepository>();
            services.AddScoped<INonAgriculturalRepository, NonAgriculturalRepository>();
            services.AddScoped<ITruckRepository, TruckRepository>();

            return services;
        }
    }
}
