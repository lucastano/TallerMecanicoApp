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
    public class AddPart : IAddPart
    {
        private readonly IPartRepository _partRepository;

        public AddPart(IPartRepository partRepository)
        {
            _partRepository = partRepository;
        }

        public void Ejecutar(Part entity)
        {
            if (entity == null) throw new Exception("algun dato falta en part");
            _partRepository.Add(entity);
        }
    }
}
