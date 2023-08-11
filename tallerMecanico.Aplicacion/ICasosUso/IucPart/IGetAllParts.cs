using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.Aplicacion.ICasosUso.IucPart
{
    public interface IGetAllParts
    {
        IEnumerable<Part> Ejecutar();
    }
}
