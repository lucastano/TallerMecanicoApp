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
    public class RepairEFRepository : IRepairRepository
    {
        TallerMecanicoContext _context;
        public RepairEFRepository(TallerMecanicoContext context)
        {
            _context = context;
        }

        public void Add(Repair entity)
        {
            if (entity == null) throw new Exception("algun dato incorrecto");
            _context.Repairs.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            if (id == 0) throw new Exception("id incorrecto");
            Repair? entity = Get(id);
            if (entity == null) throw new Exception("No se encontro reparacion con ese id");
            _context.Repairs.Remove(entity);
            _context.SaveChanges();

        }

        public Repair? Get(int id)
        {
            return _context.Repairs.Include(r => r.Parts).Include(r => r.Car).Include(r=>r.Car.Owner).FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Repair> GetAll()
        {
            return _context.Repairs.Include(r=>r.Car).Include(r=>r.Parts).Include(r=>r.Car.Owner);
        }

        public void Update(Repair entity)
        {
            throw new NotImplementedException();
        }
    }
}
