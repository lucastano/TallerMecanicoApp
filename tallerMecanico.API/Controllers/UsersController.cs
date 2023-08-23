using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using tallerMecanico.API.DTOs;

using tallerMecanico.LogicaNegocio.Entidades;
namespace tallerMecanico.API.Controllers
{
    [Route("api/[controller]")]
    //[Route("/")]

    [ApiController]
    public class UsersController : ControllerBase
    {
        //private readonly IConfiguration _config;
        //private readonly IAddUser uCAddUser;
        //private readonly IGetUser uCGetUser;
        //private readonly IGetAllUsers uCGetAllUsers;
        //private readonly IGetUserByEmail uCGetUserByEmail;

        //public UsersController(IConfiguration _config, IAddUser uCAddUser, IGetUser uCGetUser, IGetAllUsers uCGetAllUsers, IGetUserByEmail uCGetUserByEmail)
        //{
        //    this._config = _config;
        //    this.uCAddUser = uCAddUser;
        //    this.uCGetUser = uCGetUser;
        //    this.uCGetAllUsers = uCGetAllUsers;
        //    this.uCGetUserByEmail = uCGetUserByEmail;
        //}

        //[HttpPost("Add")]
        //public IActionResult Add(AddUserDTO dto)
        //{

        //    try
        //    {
        //        if (!ModelState.IsValid) throw new Exception("Falto algun dato");
        //        Seguridad.CrearPasswordHash(dto.Password, out byte[] passwordHash, out byte[] passwordSalt);

        //        User user = new User()
        //        {
        //            FirstName = dto.FirstName,
        //            LastName = dto.LastName,
        //            Phone = dto.Phone,
        //            Address = dto.Address,
        //            Ci = dto.Ci,
        //            Rol = "Usuario",
        //            Email = dto.Email,
        //            PasswordHash = passwordHash,
        //            PasswordSalt = passwordSalt


        //        };
        //        uCAddUser.Ejecutar(user);
        //        return Ok();

        //    }
        //    catch (Exception ex)
        //    {
        //        //TODO: ver el control de que estado devoler
        //        return StatusCode(500, ex.Message);

        //    }


        //}

        //    [HttpPost("login")]
        //    public IActionResult Login(LoginDTO dto)
        //    {
        //        try
        //        {
        //            if (!ModelState.IsValid) throw new Exception("falto algun dato");
        //            var user = uCGetUserByEmail.Ejecutar(dto.Email);
        //            if (user == null)
        //            {
        //                return BadRequest("No existe un usuario con esa direccion de correo ");

        //            }
        //            if (!Seguridad.VerificarPasswordHash(dto.Password, user.PasswordHash, user.PasswordSalt))
        //            {
        //                return BadRequest("Las credenciales ingresadas no son validas");
        //            }

        //            var token = Seguridad.CrearToken(user, _config);

        //            var respuesta = new LoginResponseDTO
        //            {
        //                Token = token,
        //                Usuario = new UserDTO
        //                {
        //                    FirstName = user.FirstName,
        //                    LastName = user.LastName,
        //                    Phone = user.Phone,
        //                    Address = user.Address,
        //                    Email = user.Email,
        //                    Ci=user.Id
        //                }

        //            };

        //            return Ok(respuesta);



        //        }
        //        catch(Exception ex)
        //        {
        //            return StatusCode(500, ex.Message);
        //        }

        //    }

        //    [HttpGet("GetForId")]
        //    public ActionResult<User> Get(int id)
        //    {
        //        try
        //        {
        //            if (id == 0) throw new Exception("Id Incorrecto");
        //            var user = uCGetUser.Ejecutar(id);
        //            return StatusCode(200,user);

        //        }catch(Exception ex)
        //        {
        //            return StatusCode(500,ex.Message);
        //        }

        //    }

        //    [HttpGet("GetAll")]
        //    public ActionResult<IEnumerable<User>> GetAll()
        //    {
        //        try
        //        {
        //            var users = uCGetAllUsers.Ejecutar();
        //            return StatusCode(200, users);
        //        }
        //        catch(Exception ex)
        //        {
        //            return StatusCode(500, ex.Message);
        //        }
        //    }


        }
    }

