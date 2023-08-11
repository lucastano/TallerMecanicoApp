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
    public class UpdateRepair : IUpdateRepair
    {
        private readonly IRepairRepository _repairRepository;

        public UpdateRepair(IRepairRepository repairRepository)
        {
            _repairRepository = repairRepository;
        }

        public void Ejecutar(Repair entity)
        {
            if (entity == null) throw new Exception("Falta algun dato");
            _repairRepository.Update(entity);
        }
    }
}
