using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProyectoFotoCore.Data;
using ProyectoFotoCore.Repositories;

namespace ProyectoFotoCore
{
    public class Startup
    {
        IConfiguration configuration;

        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            this.configuration = configuration;

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IPictureManagerContext, PictureManagerContext>();

            services.AddTransient<IRepositoryComision, RepositoryComision>();
            services.AddTransient<IRepositoryLogin, RepositoryLogin>();
            services.AddTransient<IRepositoryPartner, RepositoryPartner>();
            services.AddTransient<IRepositoryPhoto, RepositoryPhoto>();
            services.AddTransient<IRepositorySesion, RepositorySesion>();
            services.AddTransient<IRepositoryWork, RepositoryWork>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
