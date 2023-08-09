using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.Aplicacion.ICasosUso.IucUser;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.Aplicacion.CasosUso.UcUser
{
    public class AddUser : IAddUser
    {
      private readonly  IUserRepository _userRepository;
        public AddUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Ejecutar(User entity)
        {
            if (entity == null) throw new Exception("algun dato incorrecto");
            _userRepository.Add(entity);
        }
    }
}
