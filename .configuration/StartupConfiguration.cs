using Bank.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Bank.configuration
{
    internal static class StartupConfiguration
    {
        internal static IApplicationBuilder AddConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseRouting();

            app.UseHealthChecks("/healthCheck");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }

        internal static IServiceCollection AddSystemServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecks();
            services.AddCors();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<BankDb>(x => x.UseSqlite(configuration.GetConnectionString("BankDbConnection")));

            services.RegisterDependencies();

            return services;
        }
    }
}
