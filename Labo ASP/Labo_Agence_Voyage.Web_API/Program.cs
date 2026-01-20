using Labo_Agence_Voyage.BLL.Interfaces;
using Labo_Agence_Voyage.BLL.Services;
using Labo_Agence_Voyage.DAL.Database;
using Labo_Agence_Voyage.DAL.Repositories;
using Labo_Agence_Voyage.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Labo_Agence_Voyage.Web_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigurationManager configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddDbContext<AgenceVoyageDbContext>(options => {
                string? connectionString = configuration.GetConnectionString("DefaultConnection");
                if (connectionString is null)
                    throw new InvalidOperationException($"DefaultConnection not found {nameof(connectionString)}");

                options.UseSqlServer(connectionString);
            });

            //"BLL" ou bien de "DAL" en fonction de ce que l'on a besoin
            //Dans la Web API on a besoin des services fournis par la "BLL" qui seront utiliser dans les controlleurs
            //les respository fournis par la "DAL" afin d'intéragir avec la base de données, utiliser par la "BLL"

            //BLL
            builder.Services.AddScoped<IDestinationService, DestinationService>();
            builder.Services.AddScoped<IActiviterService, ActiviterService>();
            builder.Services.AddScoped<IReservationService, ReservationService>();

            //DAL
            builder.Services.AddScoped<IDestinationRepository, DestinationRepository>();
            builder.Services.AddScoped<IActiviterRepository, ActiviterRepository>();
            builder.Services.AddScoped<IReservationRepository, ReservationRepository>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
