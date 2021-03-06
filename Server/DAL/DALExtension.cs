using DAL.Repository;
using DAL.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAL
{
    public static class DALExtension
    {
        public static IServiceCollection AddDAL(this IServiceCollection services)
        {
            // Ses propres services
            services.AddScoped<DbSession>((services) => new DbSession(services.GetRequiredService<IConfiguration>(), "DefaultConnection"));

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Repositories
            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddTransient<IMenuRepository, MenuRepository>();
            services.AddTransient<IPlatRepository, PlatRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();


            return services;
        }
    }
}
