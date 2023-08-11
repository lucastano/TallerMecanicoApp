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
    public class GetRepair : IGetRepair
    {
        private readonly IRepairRepository _repairRepository;
        public GetRepair(IRepairRepository repairRepository)
        {
            _repairRepository = repairRepository;
        }

        public Repair? Ejecutar(int id)
        {
            if (id == 0) throw new Exception("Id incorrecto");
            return _repairRepository.Get(id);
        }
    }
}
