using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Wired.Data.Context;
using Wired.Data.IRepository;
using Wired.Data.Repository;
using Wired.Service.Abstract;
using Wired.Service.Concrete;
using Wired.Service.Mapster;

namespace Wired.Web
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
            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));
            services.AddControllers();
            services.AddDbContext<WiredContext>(options =>
                                                options.UseSqlite(@"Data Source=C:\Users\furka\source\repos\Wired\Wired.Data\my.db"));
            services.AddControllersWithViews();
            // services.AddDbContext<WiredContext>();


            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IQuestionsService, QuestionsService>();
            services.AddScoped<IArticlesService, ArticlesService>();
            services.AddScoped<IOptionsService, OptionsService>();


            services.AddScoped<IQuestionsRepository, QuestionsRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IOptionsRepository, OptionsRepository>();

            services.AddSingleton<IMapper, Mapper>();

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseCors("MyPolicy");
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Login}/{id?}");
            });
        }
    }
}
