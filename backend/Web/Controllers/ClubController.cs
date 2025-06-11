using Application.Interfaces;
using Application.Models.Request;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly IClubService _clubService;
        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        [HttpGet]
        public List<Club> GetAll()
        {
            return _clubService.GetAll();
        }

        [HttpGet("Id")]
        public Club GetById(int id) 
        {
            return _clubService.GetById(id);
        }

        [HttpPost]
        public IActionResult Create(ClubRequest club) 
        {
            
            return Ok(_clubService.Create(club));
        }
        [HttpPut("Id")]
        public IActionResult Update(int id, ClubUpdateRequest club) 
        {
            return Ok(_clubService.Update(id, club));
        }

        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            return Ok(_clubService.Delete(id));
        }
    }
}
