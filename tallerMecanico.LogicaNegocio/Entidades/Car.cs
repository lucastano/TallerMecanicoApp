﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tallerMecanico.LogicaNegocio.Entidades
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string RegistrationPlate { get; set; }
        public Customer Owner { get; set; }
        
        


    }
}
