using MoviesAPI3.Models;
using MoviesAPI3.Services;
using MoviesAPI3.Services.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MoviesAPI3.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private IDirectorServices _directorService;
        // GET: api/<DirectorController>
        public DirectorController(IDirectorServices directorService)
        {
            this._directorService = directorService;
        }

        // GET: api/<DirectorController>
        [HttpGet]
        public ActionResult<IEnumerable<Director>> Get()
        {
            //return OK(new Director[] { new Director(), new Director() });
            var director = _directorService.GetDirectors();
            if (director.Any())
            {
                return Ok(director);
            }
            else
            {
                return NotFound();
            }

            // return Ok(_directorService.GetDirectors());
        }
        // GET api/Director/American
        //[HttpGet("nationality/American")]
        //public ActionResult<IEnumerable<Director>> GetDirectorsByNationalityAmerican()
        //{
        //    var directorsAmerican = _directorService.GetDirectors()
        //                            .Where(m => m.Nationality > American).ToList();
        //    if (DirectorsAmerican.Any())
        //    {
        //        return Ok(directorsAmerican);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        //[HttpGet("model/{model}")]
        //public ActionResult<IEnumerable<Director>> GetDirectorsByAmerican(string nationality)
        //{
        //    var directorsByNationality = _directorService.GetDirectors()
        //                                               .Where(m => m.Nationality == nationality)
        //                                               .ToList();

        //    return directorsByNationality.Any() ? Ok(directorsByNationality) : NotFound();
        //}

        [HttpGet("nationality/{nationality}")]
        public ActionResult<List<Director>> GetByNationality(string nationality)
        {
            if (nationality == "")
            {
                return BadRequest();
            }
            else
            {
                var directors = _directorService.GetDirectorsNationalitys(nationality);
                if (directors != null && directors.Any())
                {
                    return Ok(directors);
                }
                else
                {
                    return NotFound();
                }
            }

        }

        // GET api/<DirectorController>/5
        [HttpGet("id{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DirectorController>
        [HttpPost]
        public IActionResult Post([FromBody] Director value)
        {
            return Ok();
        }

        // PUT api/<DirectorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Director value)
        {
            return Ok();    
        }

        // DELETE api/<DirectorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
