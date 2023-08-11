using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.AccesoDatos.EntityFramework
{
    public class PartEFRepository : IPartRepository
    {
        TallerMecanicoContext _context;

        public PartEFRepository(TallerMecanicoContext context)
        {
            _context = context;
        }

        public void Add(Part entity)
        {
            if (entity == null) throw new Exception("algun dato incorrecto");
            Part? part = GetForOEMCode(entity.OEMCode);
            if (part != null) throw new Exception("Ya existe un repuesto con ese codigo OEM");
            _context.Parts.Add(entity);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            if (id == 0) throw new Exception("no existe un repuesto con ese id");
            Part? part=Get(id);
            if (part == null) throw new Exception("no existe repuesto");
            _context.Parts.Remove(part);
            _context.SaveChanges();
        }

        public Part? Get(int id)
        {
           return _context.Parts.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Part> GetAll()
        {
            return _context.Parts;
        }

        public IEnumerable<Part> GetForCost(double desde, double hasta)
        {
            var parts=_context.Parts.Where(p=>p.Cost>=desde &&p.Cost<=hasta);
            return parts;
        }

        public IEnumerable<Part> GetForName(string name)
        {
            return _context.Parts.Where(part=>part.Name.Contains(name));
        }

        public Part? GetForOEMCode(int oemCode)
        {
            return _context.Parts.FirstOrDefault(part => part.OEMCode == oemCode);
        }

        public void Update(Part entity)
        {
            throw new NotImplementedException();
        }
    }
}
