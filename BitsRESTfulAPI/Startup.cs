using BitsBrewers.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitsRESTfulAPI
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
            // add cors policy - in a production app lock this down!
            services.AddCors(options => {
                options.AddDefaultPolicy(builder => {
                    builder.AllowAnyOrigin()
                    .WithMethods("POST", "PUT", "DELETE", "GET", "OPTIONS")
                    .AllowAnyHeader();
                });
            });


            // adding the dbContext to the service
            services.AddDbContext<BitsContext>();
            services.AddControllers() //edited here this ended eith semi colon next 2 lines were added
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
        }
        /// <summary>
        /// Endpoints
        /// </summary>

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            app.UseHttpsRedirection();

            // in a production app you would want to turn this back on!
            // app.UseHttpsRedirection();

            // enables the cors policy
            app.UseCors();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapControllers(); //didn't want to delete~not sure I need it
                //think this is what I need??
                endpoints.MapControllerRoute(
            name: "name",
            pattern: "{controller=Recipe}/{action=GetRecipeByName}/{name?}");

                endpoints.MapControllerRoute(
               name: "equipment",
               pattern: "{controller=Recipe}/{action=EquipmentName}/{name?}");

                endpoints.MapControllerRoute(
              name: "type",
              pattern: "{controller=Recipe}/{action=GetRecipeByStyle}/{name?}");
            });

            
        }
    }
}
