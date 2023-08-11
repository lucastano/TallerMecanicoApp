using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using tallerMecanico.API.DTOs;
using tallerMecanico.Aplicacion.ICasosUso.IucCar;
using tallerMecanico.Aplicacion.ICasosUso.IucRepair;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairsController : ControllerBase
    {
        private readonly IAddRepair uCAddRepair;
        private readonly IGetRepair uCGetRepair;
        private readonly IGetAllRepairs uCGetAllRepairs;
        private readonly IGetCar ucGetCar;

        public RepairsController(IAddRepair uCAddRepair, IGetRepair uCGetRepair, IGetAllRepairs uCGetAllRepairs, IGetCar ucGetCar)
        {
            this.uCAddRepair = uCAddRepair;
            this.uCGetRepair = uCGetRepair;
            this.uCGetAllRepairs = uCGetAllRepairs;
            this.ucGetCar = ucGetCar;
        }


        [HttpPost]
        public IActionResult Add(AddRepairDTO dto)
        {
            try
            {
                if (!ModelState.IsValid) {
                    return BadRequest();
                }
                Repair repair = new Repair()
                {
                    Date = dto.Date,
                    Description = dto.Description,
                    Car = ucGetCar.Ejecutar(dto.IdCar),
                    Parts = new List<Part>()

                };
                uCAddRepair.Ejecutar(repair);
                return Ok();

            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
           
        }

        [HttpGet] 
        public ActionResult<Repair> Get(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                Repair? repair = uCGetRepair.Ejecutar(id);
                if (repair == null) throw new Exception("no existe una reparacion con ese id");
                return Ok(repair);


            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.Message);

            }


        }

        [HttpGet("GetAll")]

        public ActionResult<IEnumerable<Repair>> GetAll()
        {
            //TODO: ver bien 

            try
            {
                var reparaciones =uCGetAllRepairs.Ejecutar();
                if (reparaciones == null)
                {
                    return BadRequest();
                }
               

                return Ok(reparaciones);
            
               
                

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message); 

            }
        
        }
       
    }
}
