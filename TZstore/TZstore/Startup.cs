using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TZstore
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
            services.AddControllersWithViews();
            //用于添加session的
            services.AddSession();
            services.AddDistributedMemoryCache();
            //用于数据的链接自己添加的
            services.AddDbContext<DataContext>(options => options.UseSqlite(
                Configuration.GetConnectionString("DefaultConnection"),
                sqliteOptions => {
                    sqliteOptions.MigrationsAssembly("TZstore");
                }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //使用session来记录登录状态
            app.UseSession();

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
                    //检测有没有控制器再找页面
                    pattern: "{controller=User}/{action=Index}/{id?}");
            });
        }
    }
}
