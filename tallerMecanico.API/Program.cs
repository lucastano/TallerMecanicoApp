
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Reflection;
using tallerMecanico.AccesoDatos;
using tallerMecanico.AccesoDatos.EntityFramework;
using tallerMecanico.Aplicacion.CasosUso.UcCar;
using tallerMecanico.Aplicacion.CasosUso.UcPart;
using tallerMecanico.Aplicacion.CasosUso.UcRepair;
using tallerMecanico.Aplicacion.CasosUso.UcUser;
using tallerMecanico.Aplicacion.ICasosUso.IucCar;
using tallerMecanico.Aplicacion.ICasosUso.IucPart;
using tallerMecanico.Aplicacion.ICasosUso.IucRepair;
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
            builder.Services.AddScoped<IPartRepository,PartEFRepository>();
            builder.Services.AddScoped<IRepairRepository,RepairEFRepository>();
            //use case car
            builder.Services.AddScoped<IAddCar, AddCar>();
            builder.Services.AddScoped<IDeleteCar, DeleteCar>();
            builder.Services.AddScoped<IGetAllCars, GetAllCars>();
            builder.Services.AddScoped<IGetCar, GetCar>();
            builder.Services.AddScoped<IGetCarsForBrand, GetCarsForBrand>();
            //use case user
            builder.Services.AddScoped<IAddUser,AddUser>();
            builder.Services.AddScoped<IGetUser,GetUser>();
            builder.Services.AddScoped<IGetAllUsers, GetAllUsers>();
            builder.Services.AddScoped<IGetUserByEmail, GetUserByEmail>();

            //use case Part
            builder.Services.AddScoped<IAddPart,AddPart>();
            builder.Services.AddScoped<IGetPart,GetPart>();
            builder.Services.AddScoped<IGetAllParts,GetAllParts>();

            //use case Repair
            builder.Services.AddScoped<IAddRepair,AddRepair>();
            builder.Services.AddScoped<IGetRepair,GetRepair>();
            builder.Services.AddScoped<IGetAllRepairs,GetAllRepairs>();
            builder.Services.AddScoped<IUpdateRepair,UpdateRepair>();

            //cors
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("NuevaPolitica", app =>
                {
                    app.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();

                });
            });

            builder.Services.AddEndpointsApiExplorer();




            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opciones =>
            {
                opciones.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JWT:key").Value!)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            // Add services to the container.

            builder.Services.AddControllers();
           
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            //esto es para poder ingresar el token en swagger 
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(opciones =>
            {
                opciones.SwaggerDoc("v1", new OpenApiInfo { Title = "Obligatorio APi", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                

                opciones.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme()
                {
                    Description = "autorizacion std mediante esquema bearer",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });

                opciones.OperationFilter<SecurityRequirementsOperationFilter>();

            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.UseSwagger();
            if (app.Environment.IsDevelopment())
            {
               
                app.UseSwaggerUI();
            }
           
            app.UseHttpsRedirection();
            app.UseCors("NuevaPolitica");
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();

        }
    }
}