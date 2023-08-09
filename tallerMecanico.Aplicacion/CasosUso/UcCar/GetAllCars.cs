using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.Aplicacion.ICasosUso.IucCar;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.Aplicacion.CasosUso.UcCar
{
    public class GetAllCars : IGetAllCars
    {
        private readonly ICarRepository _carRepository;

        public GetAllCars(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> Ejecutar()
        {
           return _carRepository.GetAll();
        }
    }
}
