using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmporioVirtual.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using EmporioVirtual.Repositories;
using EmporioVirtual.Repositories.Contracts;
using EmporioVirtual.Libraries.Sessao;
using EmporioVirtual.Libraries.Login;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Options;
using EmporioVirtual.Libraries.Email;
using EmporioVirtual.Libraries.Middleware;
using EmporioVirtual.Libraries.CarrinhoCompra;

namespace EmporioVirtual
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
            /*
             * Padrão repositório utilizado
             */
            // consigo injetar dependência da Libraries/Sessao/Sessao
            services.AddHttpContextAccessor();
            services.AddControllersWithViews();

            //posso injetar a classe Sessao em qualquer elemento
            services.AddScoped<Sessao>();

            services.AddScoped<EmporioVirtual.Libraries.Cookie.Cookie>();
            services.AddScoped<LoginCliente>();
            services.AddScoped<LoginColaborador>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<INewsLetterRepository, NewsLetterRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IImagemRepository, ImagemRepository>();

            services.AddMvc( options => options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(x => "O campo deve ser preenchido"));

            /*
             * SMTP 
             * AGORA INJETAR PARA OUTRAS CLASSES VEREM
             */
            services.AddScoped<SmtpClient>(options=> {
                SmtpClient smtp = new SmtpClient()
                {
                    Host = Configuration.GetValue<string>("Email:ServerSMTP"),
                    Port = Configuration.GetValue<int>("Email:ServerPort"),
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(Configuration.GetValue<string>("Email:UserEmail"), Configuration.GetValue<string>("Email:Password")),
                    EnableSsl = true
                };

                return smtp;
            });
            services.AddScoped<GerenciarEmail>();
            services.AddScoped<CarrinhoCompra>();
        

            //SESSION - Configuração 
            services.AddMemoryCache(); // guardar dados na memória
            services.AddSession(options => { 
                
            });            

            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmporioVirtual;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            services.AddDbContext<EmporioVirtualContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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
            app.UseDefaultFiles();
            app.UseStaticFiles();            
            app.UseRouting();
            app.UseSession();
            app.UseMiddleware<ValidateAntiForgeryTokenMiddleware>();

            app.UseAuthorization();

            /* configurando rotas
             * 
             * https://www.fernando.com.br um site -> qual controlador (gestão de conexões) usar -> uso de rotas
             * 
             * 
             */




            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
