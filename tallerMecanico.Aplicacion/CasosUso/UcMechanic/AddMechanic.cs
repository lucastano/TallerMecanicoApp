using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.Aplicacion.ICasosUso.IucMechanic;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.Aplicacion.CasosUso.UcMechanic
{
    public class AddMechanic : IAddMechanic
    {
        private readonly IMechanicRepository _mechanicRepository;
        public AddMechanic(IMechanicRepository mechanicRepository)
        {
            _mechanicRepository = mechanicRepository;
        }

        public void Ejecutar(Mechanic entity)
        {
            _mechanicRepository.Add(entity);
        }
    }
}
