using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.API.DTOs
{
    public class AddUserDTO
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Ci { get; set; }
        public string Password { get; set; }
    }
}

