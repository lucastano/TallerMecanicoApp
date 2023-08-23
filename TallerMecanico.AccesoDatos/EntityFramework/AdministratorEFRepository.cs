using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.AccesoDatos.EntityFramework
{
    public class AdministratorEFRepository : IAdministratorRepository
    {
        TallerMecanicoContext _context;
        public AdministratorEFRepository(TallerMecanicoContext context)
        {
            _context = context;
        }

        public void Add(Administrador entity)
        {
            if (entity == null) throw new Exception("no se puede agregar administrador");
            _context.Users.Add(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Administrador? Get(int id)
        {
            return(Administrador)_context.Users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Administrador> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Administrador entity)
        {
            throw new NotImplementedException();
        }
    }
}
