using MoviesAPI3.Models;
using MoviesAPI3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesAPI3.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]


    public class ActorsController : ControllerBase
    {
        private IActorServices _actorService;

        public ActorsController(IActorServices actorServices)
        {
            this._actorService = actorServices;
        }

        // GET: api/<ActorsController>
        [HttpGet]
        public ActionResult<IEnumerable<Actor>> Get()
        {
            // return Ok(new Actor[] { new Actor(), new Actor() });
            var actors = _actorService.GetActors();
            if (actors.Any())
            {
                return Ok(actors);
            }
            else
            {
                return NotFound();
            }

            //return OK(_actorService.GetActors());
        }
        //[HttpGet("dateofbirth /{dateofbirth}")]
        //public ActionResult<IEnumerable<Actor>> GetActorsByDateOfBirth(datetime dateofbirth)
        //{
        //    var actorsByDateOfBirth = _actorService.GetActors()
        //                                 .Where(actor => actor.DateOfBirth.ToLower() == dateofbirth.ToLower())
        //                                 .ToList();

        //    return actorsByDateOfBirth.Any() ? Ok(actorsByDateOfBirth) : NotFound();
        //}
        
        [HttpGet("dateofbirth/{dateofbirth}")]
        public IActionResult Get(DateTime dateofbirth)
        {
            if (dateofbirth == null)
            {
                return BadRequest();
            }
            else
            {
                var actors = _actorService.GetActorByDateOfBirth(dateofbirth);
                if (actors != null && actors.Any())
                {
                    return Ok(actors);
                }
                else
                {
                    return NotFound();
                }
            }
        }


        // GET api/<ActorsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id) //IActionResult -> me garantiza que me va a devolver una respuesta http 
        {
            return Ok();
        }

        // POST api/<ActorsController>
        [HttpPost]
        public IActionResult Post([FromBody] Actor value)
        {
            return Ok();
        }

        // PUT api/<ActorsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Actor value)
        {
            return Ok();
        }

        // DELETE api/<ActorsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
