using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace ExoMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // avoir accès au fichier appsettings.json
            IConfiguration configuration = builder.Configuration;
            // ajout du service pour récupérer la connection string
            // il y a 3 scope (transient = nouvelle objet à chaque demande, scope = durée de la requete, singleton = même objet durant la durée de l'appli)
            builder.Services.AddScoped<DbConnection>(sp => new SqlConnection(configuration.GetConnectionString("ExoMVCDatabase")));

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
