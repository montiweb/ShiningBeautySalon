using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ShiningBeautySalon.DependencyResolver.Ioc;

namespace ShiningBeautySalon.API
{
    public class Startup
    {
        private readonly string AllowedOrigins = "_Origins";
        private readonly IConfiguration _congiguration;
        public Startup(IConfiguration configuration)
        {
            _congiguration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(AllowedOrigins, builder =>
                {
                    builder
                        .WithOrigins(_congiguration.GetSection("AllowOrigin").Value.Split(";"))
                        .SetIsOriginAllowedToAllowWildcardSubdomains()
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
            });
            services.AddControllers();
            services.AddTransient(_congiguration);
            services.AddScoped(_congiguration);
            services.AddSingleton(_congiguration);
            services.AddControllers().AddXmlSerializerFormatters();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(AllowedOrigins);

            app.UseHttpsRedirection();

            app.UseRouting();

            //app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
