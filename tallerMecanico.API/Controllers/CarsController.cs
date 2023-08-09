﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tallerMecanico.API.DTOs;
using tallerMecanico.Aplicacion.ICasosUso.IucCar;
using tallerMecanico.Aplicacion.ICasosUso.IucUser;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IAddCar UcAddCar;
        private readonly IDeleteCar UcDeleteCar;
        private readonly IGetCar UcGetCar;
        private readonly IGetAllCars UcGetAllCars;
        private readonly IGetUser UcGetUser;

        public CarsController(IAddCar ucAddCar, IDeleteCar ucDeleteCar, IGetCar ucGetCar, IGetAllCars ucGetAllCars, IGetUser UcGetUser)
        {
            this.UcAddCar = ucAddCar;
            this.UcDeleteCar = ucDeleteCar;
            this.UcGetCar = ucGetCar;
            this.UcGetAllCars = ucGetAllCars;
            this.UcGetUser = UcGetUser;
        }

        [HttpPost]
        public IActionResult Add(AddCarDTO dTO)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return BadRequest();
                }

                Car car = new Car()
                {
                    Brand = dTO.Brand,
                    Model = dTO.Model,
                    Color = dTO.Color,
                    Year = dTO.Year,
                    RegistrationPlate = dTO.RegistrationPlate,
                    Owner = UcGetUser.Ejecutar(dTO.OwnerId)


                };
                UcAddCar.Ejecutar(car);
                return Ok();

            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }

        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetAllCars()
        {
           
                var Cars = UcGetAllCars.Ejecutar();

            return Ok(Cars);


            
        }


    }
}