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
    public class GetMechanic : IGetMechanic
    {
        private readonly IMechanicRepository _mechanicRepository;
        public GetMechanic(IMechanicRepository mechanicRepository)
        {
            _mechanicRepository = mechanicRepository;
        }

        public Mechanic Ejecutar(int id)
        {
           return _mechanicRepository.Get(id);
        }
    }
}
