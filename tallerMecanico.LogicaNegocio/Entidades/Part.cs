using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico.LogicaNegocio.Entidades
{
    public class Part
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //TODO: ver como plantear lo de compatibilidad 
        // deberia hacer una clase marcas y modelos para almacenar marcas y modelos de vehiculos existentes
        //public List<string> Compatibility { get; set; }
        public int OEMCode { get; set; }
        public double Cost { get; set; }
    }
}
