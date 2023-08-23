using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.Aplicacion.ICasosUso.IucAdministrator
{
    public interface IAddAdministrator
    {
        void Ejecutar(Administrador entity);
    }
}
