using MoviesAPI3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace MoviesAPI3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ExtrasController : ControllerBase
    {
        private readonly IExtraServices _extraService;

        public ExtrasController(IExtraServices extraService)
        {
            _extraService = extraService;
        }

        // GET api/<ExtraController>/habitat/{habitat}
        [HttpGet("rolType/{rolType}")]
        public IActionResult GetExtraByRoltype(string rolType)
        {
            var extra = _extraService.  GetExtraByRoltype(rolType);
            if (extra != null && extra.Any())
            {
                return Ok(extra);
            }
            else
            {
                return NotFound();
            }
        }

        // GET api/<ExtrasController>/name/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetExtraByName(string name)
        {
            var extra = _extraService.GetExtraByName(name);
            if (extra != null)
            {
                return Ok(extra);
            }
            else
            {
                return NotFound();
            }
        }


        // GET api/<ExtrasController>/isStuntDouble/{isStuntDouble}
        [HttpGet("isStuntDouble/{isStuntDouble}")]
        public IActionResult GetExtraByIsStuntDouble(string isStuntDouble)
        {
            var extra = _extraService.GetExtraByIsStuntDouble(isStuntDouble);
            if (extra != null && extra.Any())
            {
                return Ok(extra);
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
            var extra = _extraService.GetExtraByName(name);
            if (extra == null)
            {
                return NotFound();
            }

            _extraService.DeleteExtraByName(name);
            return NoContent();
        }
    }
}
