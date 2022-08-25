using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1_SkillsBank.Repositories.Interfaces;
using WebApp1_SkillsBank.Repositories;
using WebApp1_SkillsBank.Models;

namespace WebApp1_SkillsBank
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
            services.AddDbContext<SkillsBankContext>();

            services.AddScoped< ICourseRepository, CourseRepository>();
            services.AddScoped< ICategoryRepository, CategoryRepository>();
            services.AddScoped< ILanguageRepository, LanguageRepository>();
            services.AddScoped< ISkillsRepository, SkillsRepository>();
            services.AddScoped< IStatusRepository, StatusRepository>();
            services.AddScoped< ICrsTypeRepository, CrsTypeRepository>();
            services.AddScoped< ILevelRepository, LevelRepository>();
            services.AddScoped< ICurrencyRepository, CurrencyRepository>();

            services.AddControllersWithViews();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
