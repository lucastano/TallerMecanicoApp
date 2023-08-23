using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.AccesoDatos.EntityFramework
{
    public class MechanicEFRepository : IMechanicRepository
    {
        TallerMecanicoContext _context;
        public MechanicEFRepository(TallerMecanicoContext context)
        {
            _context = context;
        }

        public void Add(Mechanic entity)
        {
            if (entity == null) throw new Exception("mecanico no existe");
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Mechanic? Get(int id)
        {
            //TODO:ver si funciona casteo de esta manera
            return (Mechanic)_context.Users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Mechanic> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Mechanic entity)
        {
            throw new NotImplementedException();
        }
    }
}
