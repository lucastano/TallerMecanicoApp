using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.Aplicacion.ICasosUso.IucPart;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.LogicaNegocio.IRepositorios;

namespace tallerMecanico.Aplicacion.CasosUso.UcPart
{
    public class GetAllParts : IGetAllParts
    {
        private readonly IPartRepository _partRepository;
        public GetAllParts(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }
        public IEnumerable<Part> Ejecutar()
        {
          return  _partRepository.GetAll();
        }
    }
}
