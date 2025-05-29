using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidoController : ControllerBase
    {
        private readonly IPartidoService _service;

        public PartidoController (IPartidoService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_service.GetAll()); // Para el click de ver partidos (Falta Dto)

        }
    }
}
