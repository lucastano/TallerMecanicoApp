using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.API.DTOs
{
    public class LoginResponseDTO
    {
        public string Token { get; set; }
        public UserDTO Usuario { get; set; }
    }
}
