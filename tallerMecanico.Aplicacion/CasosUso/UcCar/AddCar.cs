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
    public class AddCar : IAddCar
    {
       private readonly ICarRepository _carRepository;

       public AddCar(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void Ejecutar(Car entity)
        {
            if (entity == null) throw new Exception("Auto invalido");
            //verificar si existe el auto 
            this._carRepository.Add(entity);
        }
    }
}
