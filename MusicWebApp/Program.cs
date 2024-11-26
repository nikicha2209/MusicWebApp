using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicWebApp.Data;
using MusicWebApp.Data.Models;
using MusicWebApp.Services.Data;
using MusicWebApp.Services.Data.Interfaces;

namespace MusicWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<MusicDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<ApplicationUser>(cfg => { })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<MusicDbContext>();

            string youtubeApiKey = builder.Configuration["YouTubeApiKey"] ??
                                   throw new InvalidOperationException("YouTube API key not found.");

            builder.Services.AddScoped<IYouTubeServiceClient>(provider =>
                new YouTubeServiceClient(youtubeApiKey, provider.GetRequiredService<MusicDbContext>()));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}
