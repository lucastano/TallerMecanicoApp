using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico.LogicaNegocio.Entidades
{
    [Table("Customers")]
    public class Customer:User
    {
        public string Ci { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
