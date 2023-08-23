using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tallerMecanico.API.DTOs;
using tallerMecanico.Aplicacion.ICasosUso.IucMechanic;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicsController : ControllerBase
    {
        private readonly IAddMechanic ucAddMechanic;
        private readonly IGetMechanic ucGetMechanic;
        //private readonly IGetAllMechanics ucGetAllMechanics;

        public MechanicsController(IAddMechanic ucAddMechanic, IGetMechanic ucGetMechanic)
        {
            this.ucAddMechanic = ucAddMechanic;
            this.ucGetMechanic = ucGetMechanic;
            
        }

        [HttpPost]
        public IActionResult Add(AddMechanicDTO dto)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception("Algun dato incompleto");
                Seguridad.CrearPasswordHash(dto.Password, out byte[] passwordHash, out byte[] passwordSalt);

                Mechanic mechanic = new Mechanic()
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Email = dto.Email,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                    Rol = "Mechanic",


                };
                ucAddMechanic.Ejecutar(mechanic);
                return Ok();

            }catch (Exception ex)
            {
                return StatusCode(500,ex.Message);

            }

        }



    }
}
