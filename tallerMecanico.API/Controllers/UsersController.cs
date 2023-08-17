using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tallerMecanico.API.DTOs;
using tallerMecanico.Aplicacion.ICasosUso.IucUser;
using tallerMecanico.LogicaNegocio.Entidades;
namespace tallerMecanico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAddUser uCAddUser;
        private readonly IGetUser uCGetUser;
        private readonly IGetAllUsers uCGetAllUsers;

        public UsersController(IAddUser uCAddUser, IGetUser uCGetUser, IGetAllUsers uCGetAllUsers)
        {
            this.uCAddUser = uCAddUser;
            this.uCGetUser = uCGetUser;
            this.uCGetAllUsers = uCGetAllUsers;
        }

        [HttpPost]
        public IActionResult Add(AddUserDTO dto)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception("Falto algun dato");

                User user = new User()
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Phone = dto.Phone,
                    Address = dto.Address,
                    UserLvl = dto.UserLvl
                };
                uCAddUser.Ejecutar(user);
                return Ok();

            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);

            }
            

        }

        [HttpGet("GetForId")]
        public ActionResult<User> Get(int id)
        {
            try
            {
                if (id == 0) throw new Exception("Id Incorrecto");
                var user = uCGetUser.Ejecutar(id);
                return StatusCode(200,user);

            }catch(Exception ex)
            {
                return StatusCode(500,ex.Message);
            }

        }

        [HttpGet("GetAll")]
        public ActionResult<IEnumerable<User>> GetAll()
        {
            try
            {
                var users = uCGetAllUsers.Ejecutar();
                return StatusCode(200, users);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


    }
}
