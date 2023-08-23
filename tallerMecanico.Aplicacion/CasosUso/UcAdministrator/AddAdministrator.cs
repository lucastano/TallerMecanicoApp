using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.Aplicacion.ICasosUso.IucAdministrator;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.Aplicacion.CasosUso.UcAdministrator
{
    public class AddAdministrator : IAddAdministrator
    {
        private readonly IAdministratorRepository _repository;
        public AddAdministrator(IAdministratorRepository repository)
        {
            _repository = repository;
        }

        public void Ejecutar(Administrador entity)
        {
            _repository.Add(entity);
        }
    }
}
