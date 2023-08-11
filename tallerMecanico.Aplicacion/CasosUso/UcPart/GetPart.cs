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
    public class GetPart : IGetPart
    {
        private readonly IPartRepository _partRepository;

        public GetPart(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }
        public Part? Ejecutar(int id)
        {
            if (id == 0) throw new Exception("Id incorrecto");
            return _partRepository.Get(id);
        }
    }
}
