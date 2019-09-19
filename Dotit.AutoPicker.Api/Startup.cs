using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DotIt.AutoPickerApi.Data.DotIt;
using DotIt.AutoPickerApi.Data.Epicor;
using DotIt.AutoPickerApi.Data.UnitOfWork;
using DotIt.AutoPickerApi.Persistance.Repository;
using DotIt.AutoPickerApi.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace Dotit.AutoPickerApi
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // var connection = Configuration.GetConnectionString("DotitPickerConnection");  //  "Data Source=192.168.1.150;Initial Catalog=DotItPicker;Persist Security Info=True;User ID=sa;Password=@password1";
            services.AddDbContext<DotitExtensionContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DotitPickerConnection")));
            services.AddDbContext<ERP102TestContext>(options => options.UseSqlServer(Configuration.GetConnectionString("EpicorDotItConnection")));

            services.AddTransient<StackTrace>();

            services.AddTransient<IPickerRepository, PickerRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork<PickerRepository>>();
            services.AddTransient<IEpicorServiceApi, EpicorServiceApi>();
            services.AddTransient<IDotitService, DotitService>();



            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Dotit Auto Picker API", Version = "v1" });
            });
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DOTIT AUTO PICKER API V1");
             
            });
        }
    }
}
