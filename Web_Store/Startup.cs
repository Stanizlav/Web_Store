using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Web_Store
{
    public class Startup
    {
        private readonly IConfiguration _Configuration;
        public Startup(IConfiguration Configuration) => _Configuration = Configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
             {
                 endpoints.MapGet("/greetings", async context => await context.Response.WriteAsync(_Configuration["greetings"]));
                 endpoints.MapControllerRoute(
                     name:"default",
                     pattern:"{controller=Home}/{action=Index}/{id?}");
             });
        }
    }
}
