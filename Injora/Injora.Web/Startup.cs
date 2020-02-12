using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Injora.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Qwantalabs.Shared;

namespace Injora
{
    public class Startup
    {
        private IConfiguration Configuration { get; }
        
        public Startup(IConfiguration cfg)
        {
            Configuration = cfg;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.SetupIoC(typeof(Startup), Configuration);
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Projects}/{action=List}/{id?}");
            });
            
            // Ensure the database contains data.
            SeedData.EnsurePopulated(app);
        }
    }
}


// endpoints.MapDefaultControllerRoute();
// is the same as:
// routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}")

// routes.MapRoute("blog", "blog/{*article}", <<<<<<< catchall parameter
//                  defaults: new { controller = "Blog", action = "Article" });

// app.UseMvc(routes => {
//    routes.MapRoute(
//    name: "default",
//    template: "{controller=Product}/{action=List}/{id?}");
// });

// IActionConstraints: Define constraints to disambiguate routes. HttpGet and HttpPost is one. Inherited by [HttpGet], [HttpPost].
// IRouteTemplateProvider: type inherited by route attributes. To set custom route templates. Inherited by [Route]
// IControllerModelConvention:  Modify the application model at startup time to customize how routing behaves.
// IUrlHelper: To build urls based on context. 
//      Implementations: Controller.Url, view.Url
//      Methods: IUrlHelper.Action, IUrlHelper.RouteUrl
// IHtmlHelper: To build html stuff easily.
//      Methods: IHtmlHelper.BeginForm, IHtmlHelper.ActionLink