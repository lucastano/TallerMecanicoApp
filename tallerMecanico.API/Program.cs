
using Microsoft.EntityFrameworkCore;
using tallerMecanico.AccesoDatos;
using tallerMecanico.AccesoDatos.EntityFramework;
using tallerMecanico.Aplicacion.CasosUso.UcCar;
using tallerMecanico.Aplicacion.CasosUso.UcUser;
using tallerMecanico.Aplicacion.ICasosUso.IucCar;
using tallerMecanico.Aplicacion.ICasosUso.IucUser;
using tallerMecanico.LogicaNegocio.IRepositorios;

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
            //repositorio 
            builder.Services.AddScoped<ICarRepository,CarEFRepository>();
            builder.Services.AddScoped<IUserRepository,UserEFRepository>();
            //use case car
            builder.Services.AddScoped<IAddCar, AddCar>();
            builder.Services.AddScoped<IDeleteCar, DeleteCar>();
            builder.Services.AddScoped<IGetAllCars, GetAllCars>();
            builder.Services.AddScoped<IGetCar, GetCar>();
            //use case user
            builder.Services.AddScoped<IAddUser,AddUser>();
            builder.Services.AddScoped<IGetUser,GetUser>();
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