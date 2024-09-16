using MoviesAPI3.Models;
using MoviesAPI3.Services;
using MoviesAPI3.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesAPI3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorServices _directorService;

        public DirectorController(IDirectorServices directorService)
        {
            _directorService = directorService;
        }

        // GET api/<DirectorController>/habitat/{habitat}
        [HttpGet("rolType/{rolType}")]
        public IActionResult GetDirectorByRoltype(string rolType)
        {
            var director = _directorService.GetDirectorByRoltype(rolType);
            if (director != null && director.Any())
            {
                return Ok(director);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<DirectorsController>/name/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var director = _directorService.GetDirectorByName(name);
            if (director != null)
            {
                return Ok(director);
            }
            else
            {
                return NotFound();
            }
        }


        // GET api/<DirectorController>/visualStyle/{visualStylet}
        [HttpGet("visualStyle/{visualStyle}")]
        public IActionResult GetDirectorByVisualStyle(string visualStyle)
        {
            var director = _directorService.GetDirectorByVisualStyle(visualStyle);
            if (director != null && director.Any())
            {
                return Ok(director);
            }
            else
            {
                return NotFound();
            }
        }






        // DELETE api/<AerialController>/name/{name}
        [HttpDelete("name/{name}")]
        public IActionResult DeleteByName(string name)
        {
            var director = _directorService.GetDirectorByName(name);
            if (director == null)
            {
                return NotFound();
            }

            _directorService.DeleteDirectorByName(name);
            return NoContent();
        }
    }
}
