using DotIt.AutoPicker.Data;
using DotIt.AutoPicker.Data.DotIt;
//using DotIt.AutoPicker.Data.Epicor;
using DotIt.AutoPicker.Models;
using DotIt.AutoPicker.Persistance.Repository;
//using DotIt.AutoPicker.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DotIt.AutoPicker
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = System.TimeSpan.FromHours(120);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });
            services.Configure<IISOptions>(options =>
            {
                options.ForwardClientCertificate = false;
            });



            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            //services.AddScoped<IPickerRepository>();
            // var connection = Configuration.GetConnectionString("DotitPickerConnection");  //  "Data Source=192.168.1.150;Initial Catalog=DotItPicker;Persist Security Info=True;User ID=sa;Password=@password1";
           services.AddDbContext<DotitExtensionContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DotitPickerConnection")));
          //  services.AddDbContext<Erp102TestContext>(options => options.UseSqlServer(Configuration.GetConnectionString("EpicorDotItConnection")));
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession(); 
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Admin}/{action=Default}/{id?}");
            });
        }
    }
}
