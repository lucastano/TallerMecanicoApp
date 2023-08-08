
using Microsoft.EntityFrameworkCore;
using tallerMecanico.AccesoDatos;

namespace tallerMecanico.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //add context
            builder.Services.AddDbContext<TallerMecanicoContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("TallerMecanicoContext"));

            });

            //add use case and repositories


            // Add services to the container.

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