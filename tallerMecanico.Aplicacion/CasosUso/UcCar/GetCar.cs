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
    public class GetCar : IGetCar
    {
       private readonly ICarRepository _carRepository;
       public GetCar(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public Car? Ejecutar(int id)
        {
            if (id == 0) throw new Exception("Id iconrrecto");
            return _carRepository.Get(id);
        }
    }
}
