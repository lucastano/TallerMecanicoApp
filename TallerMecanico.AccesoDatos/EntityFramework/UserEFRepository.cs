using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.AccesoDatos.EntityFramework
{
    public class UserEFRepository : IUserRepository
    {        
        TallerMecanicoContext _context;

        public UserEFRepository(TallerMecanicoContext context)
        {
            _context = context;
        }

        public void Add(User entity)
        {
            if (entity == null) throw new Exception("falto algun dato");
            User user = GetByEmail(entity.Email);
            if (user != null) throw new Exception("ya existe un usuario con esa cedula");
            _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User? Get(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
