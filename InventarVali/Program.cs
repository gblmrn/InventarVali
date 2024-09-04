using InventarVali.DataAccess.Data;
using InventarVali.DataAccess.Repository;
using InventarVali.DataAccess.Repository.IRepository;
using InventarVali.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarVali
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(options => 
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
            builder.Services.AddAutoMapper(typeof(MappingConfig));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{area=Employee}/{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
