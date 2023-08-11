using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.Aplicacion.ICasosUso.IucRepair;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.Aplicacion.CasosUso.UcRepair
{
    public class AddRepair : IAddRepair
    {
        private readonly IRepairRepository _repairRepository;

        public AddRepair(IRepairRepository repairRepository)
        {
            _repairRepository = repairRepository;
        }

        public void Ejecutar(Repair entity)
        {
            if (entity == null) throw new Exception("reparacion no encontrada");
            _repairRepository.Add(entity);
        }
    }
}
