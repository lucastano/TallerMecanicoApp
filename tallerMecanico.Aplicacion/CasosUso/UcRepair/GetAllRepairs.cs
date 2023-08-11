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
    public class GetAllRepairs : IGetAllRepairs
    {
        private readonly IRepairRepository _repairRepository;
        public GetAllRepairs(IRepairRepository repairRepository)
        {
            _repairRepository = repairRepository;
        }

        public IEnumerable<Repair> Ejecutar()
        {
           return _repairRepository.GetAll();
        }
    }
}
