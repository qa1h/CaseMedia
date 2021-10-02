using CaseMediaMVC.Busineess;
using CaseMediaMVC.Data;
using CaseMediaMVC.Data.Interfaces;
using CaseMediaMVC.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
namespace CaseMediaMVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CaseMediaDBSettings>(Configuration.GetSection("MongoDbSettings"));

            services.AddSingleton<ICaseMediaDBSettings>(serviceProvider => serviceProvider.GetRequiredService<IOptions<CaseMediaDBSettings>>().Value);

            services.AddSingleton<ICaseMediaDBContext, CaseMediaDBContext>();

            services.RegisterRepositories();
            services.RegisterServices();

            services.AddControllersWithViews();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("CaseMediaApi", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Case Media API",
                    Description = "Case Media API Docs"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/CaseMediaApi/swagger.json", "Case Media API");
            });

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "newsdetail", 
                    pattern: "{category}/{title}/{id}",
                    defaults: new { controller = "Home", action = "Detail" });
                    

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //endpoints.MapControllers();
            });


        }
    }
}
