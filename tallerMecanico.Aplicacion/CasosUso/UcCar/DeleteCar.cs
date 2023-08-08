using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.Aplicacion.ICasosUso.IucCar;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.Aplicacion.CasosUso.UcCar
{
    public class DeleteCar : IDeleteCar
    {
        private readonly ICarRepository _carRepository;

        public DeleteCar(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void Ejecutar(int id)
        {
            if (id == 0) throw new Exception("Id incorrecto");
            _carRepository.Delete(id);
        }
    }
}
