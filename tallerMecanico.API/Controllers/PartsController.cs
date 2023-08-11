using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tallerMecanico.Aplicacion.ICasosUso.IucPart;
using tallerMecanico.LogicaNegocio.Entidades;
using tallerMecanico.API.DTOs;

namespace tallerMecanico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartsController : ControllerBase
    {
        private readonly IAddPart uCAddPart;
        private readonly IGetAllParts uCGetAllParts;
        private readonly IGetPart uCGetPart;
        public PartsController(IAddPart uCAddPart, IGetAllParts uCGetAllParts, IGetPart uCGetPart)
        {
            this.uCAddPart = uCAddPart;
            this.uCGetPart = uCGetPart;
            this.uCGetAllParts = uCGetAllParts;

        }

        [HttpPost]
        public IActionResult Add(AddPartDTO DTO)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                Part part = new Part()
                {
                    Name = DTO.Name,
                    Description = DTO.Description,
                    OEMCode = DTO.OEMCode,
                    Cost = DTO.Cost,
                };

                uCAddPart.Ejecutar(part);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500,ex.Message);

            }
           

        }
        [HttpGet]
        public ActionResult<IEnumerable<Part>> GetAll()
        {
            try
            {
                var parts = uCGetAllParts.Ejecutar();
                return Ok(parts);

            }
            catch(Exception ex)
            {
                return StatusCode(500,ex.Message);

            }
        }


    }
}
