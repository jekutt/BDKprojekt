using Loppprojekt.Domain.Cars.Generations;
using Loppprojekt.Domain.Cars.Marks;
using Loppprojekt.Domain.Cars.Models;
using Loppprojekt.Domain.Motorbikes.Marks;
using Loppprojekt.Domain.Motorbikes.Models;
using Loppprojekt.Domain.Sales.Statements;
using Loppprojekt.Infra.Cars.CarsDb;
using Loppprojekt.Infra.Cars.Generations;
using Loppprojekt.Infra.Cars.Marks;
using Loppprojekt.Infra.Cars.Models;
using Loppprojekt.Infra.Motorbikes.BikeDb;
using Loppprojekt.Infra.Motorbikes.Marks;
using Loppprojekt.Infra.Motorbikes.Models;
using Loppprojekt.Infra.Sales.Statements;
using Loppprojekt.Infra.Sales.StatementsDb;
using Loppprojekt.Soft.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Loppprojekt.Soft
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<CarsDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<BikeDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<StatementsDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages();
            services.AddScoped<IMarksRepository, MarksRepository>();
            services.AddScoped<IModelsRepository, ModelsRepository>();
            services.AddScoped<IGenerationsRepository, GenerationsRepository>();
            services.AddScoped<IBikeMarksRepository, BikeMarksRepository>();
            services.AddScoped<IBikeModelsRepository, BikeModelsRepository>();
            services.AddScoped<ISalesStatementsRepository, SalesStatementsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
                endpoints.MapRazorPages();
            });
        }
    }
}
