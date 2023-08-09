using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.API.DTOs
{
    public class AddCarDTO
    {
    
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string RegistrationPlate { get; set; }
        public int OwnerId { get; set; }
       

    }
}
