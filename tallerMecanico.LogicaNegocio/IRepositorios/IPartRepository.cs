using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.LogicaNegocio.IRepositorios
{
    public interface IPartRepository:IRepository<Part>
    {
        Part GetForOEMCode(int oemCode);
        IEnumerable<Part> GetForCost(double desde, double hasta);
        IEnumerable<Part> GetForName(string name);

    }
}
