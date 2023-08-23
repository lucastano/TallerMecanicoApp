using System.ComponentModel.DataAnnotations;

namespace tallerMecanico.API.DTOs
{
    public class AddMechanicDTO
    {

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        
        
    }
}
