using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.AccesoDatos.EntityFramework
{
   
    public class CarEFRepository : ICarRepository
    {
        TallerMecanicoContext _context;

        public CarEFRepository(TallerMecanicoContext context)
        {
            _context = context;
        }

        public void Add(Car entity)
        {
            if (entity is null) throw new Exception("datos invalidos");

            _context.Cars.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {

            Car? car = Get(id);
            if (car == null) throw new Exception("no existe el vehiculo");
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }

        public Car? Get(int id)
        {
           return _context.Cars.Include(c=>c.Owner).FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Car> GetAll()
        {
            return _context.Cars.Include(c=>c.Owner);
        }

        public IEnumerable<Car> GetForBrand(string brand)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetForColor(string color)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetForModel(string model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetForOwner(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetForRegPlate(string registrationPlate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetForYear(int year)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
