using IdentitySecuredApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentitySecuredApp
{
    public class Startup
    {
        public string cs1 { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            this.cs1 = configuration.GetConnectionString("cs1");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<MyIdentityDbContext>(options => options.UseSqlServer(cs1));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MyIdentityDbContext>();


            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(180);
            });

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
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Accounts}/{action=Index}/{id?}");
            });
        }
    }
}
