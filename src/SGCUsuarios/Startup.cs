using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SGC.Models;
using Microsoft.Extensions.Configuration;//extension que se utiliza con IConfigurationRoot
using Microsoft.EntityFrameworkCore;//extension para conexion con sqlserver

namespace SGC
{
    public class Startup
    {
        //propiedad para administrar la conexion con el DBMS
        private IConfigurationRoot _configurationRoot;
        //agregacion del metodo constructor de la clase Starup para la instancia dde la conexion
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }//fin constructor
        public void ConfigureServices(IServiceCollection services)
        {
            //registrar AppDBContext para interactuar con la conexion DBMS
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            //Registrar clases repositorios y mock
            // services.AddTransient<IUsuariosRepositorios, MockUsuariosRepositorios>();
            services.AddTransient<IUsuariosRepositorios, UsuariosRepositorios>();
            services.AddTransient<INiveles, NivelesRepositorios>();

            /*services.AddTransient<IClasificacionDoc, ClasificacionDocRepositorios>();
            services.AddTransient<IDocumentos, DocumentosRepositorios>();
            services.AddTransient<ICargos, CargosRepositorios>();
            services.AddTransient<IDepartamento, DepartamentosRepositorios>();*/

            //agregar soporte MVC
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseDeveloperExceptionPage();
           // DataInicio.AgregarData(app);
            DataInicio.AgregarDataU(app);
            //DataInicio.AgregarDataE(app);
        }

    }
}
