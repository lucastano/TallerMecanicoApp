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
    public class GetCarsForBrand : IGetCarsForBrand
    {
        private readonly ICarRepository _carRepository;

        public GetCarsForBrand(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> Ejecutar(string brand)
        {
           return _carRepository.GetForBrand(brand);
        }
    }
}
