using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.API.DTOs
{
    public class AddRepairDTO
    {
       
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int IdCar { get; set; }
        public int IdMechanic { get; set; }

    }
}
