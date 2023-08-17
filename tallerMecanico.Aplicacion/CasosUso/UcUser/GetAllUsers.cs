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
    public class GetAllUsers : IGetAllUsers
    {
        private readonly IUserRepository _repository;

        public GetAllUsers(IUserRepository repository)
        {
            this._repository = repository;
        }
        public IEnumerable<User> Ejecutar()
        {
           return _repository.GetAll();
        }
    }
}
