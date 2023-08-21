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
    public class GetUserByEmail : IGetUserByEmail
    {
        private readonly IUserRepository _repository;
        public GetUserByEmail(IUserRepository repository)
        {
            _repository = repository;
        }
        public User Ejecutar(string email)
        {
            return _repository.GetByEmail(email);
        }
    }
}
