using Application.Interfaces;
using Application.Models.Request;
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
            // Nombre posicion y goles

            return Ok(_jugadorService.GetAll());
        }
        [HttpPost]

        public IActionResult Create(JugadorRequest jugadorRequest) 
        {
            return Ok(_jugadorService.Create(jugadorRequest));
        }

    }
}
