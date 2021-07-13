using Combi19.Data;
using Combi19.Data.Repositorios;
using Combi19.Ui.Areas.Identity;
using Combi19.Ui.Data;
using Combi19.Ui.Interfaces;
using Combi19.Ui.Servicios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Combi19.Ui
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            var sqlConnectionConfiguration = new SqlConfiguration(Configuration.GetConnectionString("DefaultConnection"));
            services.AddSingleton(sqlConnectionConfiguration);
        
            services.AddScoped<IServicioChofer, ServicioChofer>();
            services.AddScoped<IServicioCiudad, ServicioCiudad>();
            services.AddScoped<IServicioCombi, ServicioCombi>();
            services.AddScoped<IServicioInsumo, ServicioInsumo>();
            services.AddScoped<IServicioProvincia, ServicioProvincia>();
            services.AddScoped<IServicioRuta, ServicioRuta>();
            services.AddScoped<IServicioUsuario, ServicioUsuario>();
            services.AddScoped<IServicioComentario, ServicioComentario>();
            services.AddScoped<IServicioViaje, ServicioViaje>();
            services.AddScoped<IServicioPasaje, ServicioPasaje>();
            services.AddScoped<IServicioVenta, ServicioVenta>();
            services.AddScoped<IServicioListaInsumo, ServicioListaInsumo>();
            services.AddScoped<IServicioTesteo, ServicioTesteo>();

            services.AddScoped <UserManager<AspNetUsers>>();


            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<AspNetUsers, IdentityRole>(options => {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = true;
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
