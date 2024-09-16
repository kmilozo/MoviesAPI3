using MoviesAPI3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace MoviesAPI3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ActorsController : ControllerBase
    {
        private readonly IActorServices _actorService;

        public ActorsController(IActorServices actorService)
        {
            _actorService = actorService;
        }

        // GET api/<AerialController>/habitat/{habitat}
        [HttpGet("rolType/{rolType}")]
        public IActionResult GetActorByRoltype(string rolType)
        {
            var actor = _actorService.  GetActorByRoltype(rolType);
            if (actor != null && actor.Any())
            {
                return Ok(actor);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<ActorsController>/name/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name)
        {
            var actor = _actorService.GetActorByName(name);
            if (actor != null)
            {
                return Ok(actor);
            }
            else
            {
                return NotFound();
            }
        }


        // GET api/<ActorController>/actingExperience/{actingExperience}
        [HttpGet("actingExperience/{actingExperience}")]
        public IActionResult GetActorByActingExperience(string actingExperinece)
        {
            var actor = _actorService.GetActorByActingExperience(actingExperinece);
            if (actor != null && actor.Any())
            {
                return Ok(actor);
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
            var actor = _actorService.GetActorByName(name);
            if (actor == null)
            {
                return NotFound();
            }

            _actorService.DeleteActorByName(name);
            return NoContent();
        }
    }
}
