using Labo_Agence_Voyage.ASP_MVC.Services;

namespace Labo_Agence_Voyage.ASP_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigurationManager configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddHttpClient<AgenceVoyageApiClient>(configCli => {
                IConfigurationSection APISection = configuration.GetSection("API");
                string? APIBaseAddress = APISection.GetSection("Labo_Agence_voyage").GetValue<string>("BASE_URI");
                if (APIBaseAddress is null)
                    throw new InvalidOperationException($"API base uri not found, {nameof(APIBaseAddress)}");

                configCli.BaseAddress = new Uri(APIBaseAddress);
            });

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
                pattern: "{controller=Home}/{action=Index}");

            app.Run();
        }
    }
}
