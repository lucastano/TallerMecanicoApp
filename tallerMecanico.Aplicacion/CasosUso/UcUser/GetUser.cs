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
    public class GetUser : IGetUser
    {
        private readonly IUserRepository _userRepository;
        public GetUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? Ejecutar(int id)
        {
            return _userRepository.Get(id);
        }
    }
}
