using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.LogicaNegocio.IRepositorios
{
    public interface ICarRepository:IRepository<Car>
    {
        IEnumerable<Car> GetForColor(string color);
        IEnumerable<Car> GetForBrand(string brand);
        IEnumerable<Car> GetForModel(string model);
        IEnumerable<Car> GetForYear(int year);
        IEnumerable<Car> GetForRegPlate(string registrationPlate);
        IEnumerable<Car> GetForOwner(int id);


        


    }
}
