using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
       public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
       {
           services.AddScoped<ITokenService, TokenService>();      //JWT Token Service
            services.AddDbContext<DataContext>(options =>           //DB Connection
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

            return services;
       }
    }
}