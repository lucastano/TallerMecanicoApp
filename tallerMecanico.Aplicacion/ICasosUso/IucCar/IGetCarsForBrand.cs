using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.Aplicacion.ICasosUso.IucCar
{
    public interface IGetCarsForBrand
    {
        IEnumerable<Car> Ejecutar(string brand);
    }
}
