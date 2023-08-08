using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;


namespace tallerMecanico.Aplicacion.ICasosUso.IucCar
{
    public interface IAddCar
    {
        void Ejecutar(Car entity);
    }
}
