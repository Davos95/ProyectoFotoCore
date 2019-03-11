using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
            String cadenaConexionAzure = this.configuration.GetConnectionString("conexionAzure");
            services.AddDbContext<IPictureManagerContext, PictureManagerContext>(options => options.UseSqlServer(cadenaConexionAzure));

            services.AddTransient<IRepositoryComision, RepositoryComision>();
            services.AddTransient<IRepositoryLogin, RepositoryLogin>();
            services.AddTransient<IRepositoryPartner, RepositoryPartner>();
            services.AddTransient<IRepositoryPhoto, RepositoryPhoto>();
            services.AddTransient<IRepositorySesion, RepositorySesion>();
            services.AddTransient<IRepositoryWork, RepositoryWork>();



            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddAuthentication(options => {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie();

            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //6. AUTHENTICATION
            app.UseAuthentication();

            //7. UTILIZAMOS LA SESION
            app.UseSession();


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Login}/{id?}");
            });
        }
    }
}
