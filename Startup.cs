using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components.Forms;

using mvc001.Repositorio;

namespace mvc001
{
    public partial class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddApplicationInsightsTelemetry(); // adicionar quando migrar netcore 2 para 3
            services.AddDistributedMemoryCache();
            services.AddSession();
            //services.AddControllers().AddNewtonsoftJson();
            //services.AddControllersWithViews().AddNewtonsoftJson();

            //   sem este serviço adicionado a deserialização AJAX não funciona no Controller
            services.AddRazorPages().AddNewtonsoftJson();            

            string connetcionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<AppContext>(options => 
                        options.UseSqlServer(connetcionString)
                        );


            services.AddScoped<AppContext, AppContext>();
            services.AddControllers();
                        
          //.AddXmlSerializerFormatters();
            // registrando os serviços para a Interface/Classe que irá inicializar o BD

            services.AddTransient<IDataService,DataService>();
            services.AddTransient<IRepositorioInsumo, RepositorioInsumo>();
            services.AddTransient<IRepositorioReceita, RepositorioReceita>();
            services.AddTransient<IRepositorioItemReceita, RepositorioItemReceita>();
            services.AddTransient<IRepositorioCadastro, RepositorioCadastro>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
                              IServiceProvider serviceProvider)
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
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=receita}/{action=carrossel}/{codigo?}");
            });

            serviceProvider.GetService<IDataService>().InicializaDB();

        }

    }
}
