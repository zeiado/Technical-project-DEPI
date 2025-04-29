using Fitness_App.BL.Interfaces;
using Fitness_App.BL.Servecies;
using Fitness_App.BL.ViewModels;
using Fitness_App.DAL.DbContext;
using Fitness_App.DAL.Models;
using Fitness_App.DAL.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FitnessAPPMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<FitnessAppDbContext>(option =>
               option.UseSqlServer(builder.Configuration.GetConnectionString("cs")));
            builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>()
                .AddEntityFrameworkStores<FitnessAppDbContext>();

            builder.Services.AddScoped<IAdminRepository<Blogs>, AdminRepository<Blogs>>();
            builder.Services.AddScoped<IAdminRepository<BlogViewModel>, AdminRepository<BlogViewModel>>();
            builder.Services.AddScoped(typeof(IAdminRepository<DietPlans>), typeof(AdminRepository<DietPlans>));
            
            builder.Services.AddScoped<BlogServecies>();
            builder.Services.AddScoped<DietPlanService>();


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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
