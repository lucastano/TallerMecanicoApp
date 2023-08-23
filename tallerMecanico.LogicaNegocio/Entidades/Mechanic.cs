using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico.LogicaNegocio.Entidades
{
    [Table("Mechanics")]
    public class Mechanic:User
    {

        public static double CostoHora { get; set; } = 10000;
    }
}

