using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        private readonly IJugadorService _jugadorService;
        public JugadorController(IJugadorService jugadorService)
        {
            _jugadorService = jugadorService;
        }

        [HttpGet]

        public IActionResult Get() 
        {
            return Ok(_jugadorService.GetAll());
        }
        [HttpPost]

        public IActionResult Create(Jugador jugador) 
        {
            return Ok(_jugadorService.Create(jugador));
        }
    }
}
