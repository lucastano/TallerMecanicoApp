using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.AccesoDatos
{
    public class TallerMecanicoContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Part>Parts { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<User>Users { get; set; }


        public TallerMecanicoContext(DbContextOptions<TallerMecanicoContext> options) : base(options)
        {

        }



    }
}
