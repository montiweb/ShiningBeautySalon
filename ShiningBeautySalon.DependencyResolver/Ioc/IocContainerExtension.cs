using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ShiningBeautySalon.Core.Repository;
using ShiningBeautySalon.DAL.Context;
using ShiningBeautySalon.DAL.Repository;
using ShiningBeautySalon.DAL.UnitOfWork;
using ShiningBeautySalon.Service.Interfaces;
using ShiningBeautySalon.Service.Services;

namespace ShiningBeautySalon.DependencyResolver.Ioc
{
    public static class IocContainerExtension
    {
        public static IServiceCollection AddTransient(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IServiceCollection AddScoped(this IServiceCollection services, IConfiguration configuration)
        {
            #region Context
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddContext<ShiningContext>(configuration.GetConnectionString("DefaultConnection"));
            #endregion

            #region Services 
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<ILevelService, LevelService>();
            services.AddScoped<ISalonService, SalonService>();
            services.AddScoped<IServiceCategoryService, ServiceCategoryService>();
            services.AddScoped<IStaffService, StaffService>();
            #endregion

            return services;
        }

        public static IServiceCollection AddSingleton(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IServiceCollection AddContext<TDbContext>(this IServiceCollection services, string conectionString) where TDbContext : DbContext
        {
            services.AddDbContext<TDbContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer(conectionString,
                            sqlServerOption =>
                            {
                                sqlServerOption.MaxBatchSize(1000);
                                sqlServerOption.CommandTimeout(null);
                                sqlServerOption.UseRelationalNulls(false);
                            });
            });
            return services;
        }
    }
}
