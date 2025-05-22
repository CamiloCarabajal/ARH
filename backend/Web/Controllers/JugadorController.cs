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

        [HttpGet ("ById")]
        public IActionResult  Get(int id) 
        {
            var jugador = _jugadorService.GetById;
            if (jugador == null) 
            {
                return BadRequest();
            }else
                { return Ok(jugador); }
        }
        [HttpPost]

        public IActionResult Create(JugadorRequest jugadorRequest) 
        {
            return Ok(_jugadorService.Create(jugadorRequest));
        }

        [HttpPut]
        public IActionResult Update(JugadorRequest jugadorRequest, int id)
        {
            var jugador = _jugadorService.Update(jugadorRequest, id);
            if (jugador == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(jugador); }
        }
    }
}
