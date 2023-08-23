using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico.LogicaNegocio.Entidades
{
    public class Repair
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Car Car { get; set; }
        public string Details { get; set; }
        public List<Part>? Parts { get; set; }//this is a list of parts to repair a car 
        public string State { get; set; }//4 states: initiated,presupuestado(esperando confirmacion),in progress,finish
        public Mechanic Mechanic { get; set; }
    }
}
