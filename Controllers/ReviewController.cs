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
    public class ReviewController : ControllerBase
    {
        private IReviewServices _reviewService;
        // GET: api/<ReviewController>
        public ReviewController(IReviewServices reviewService)
        {
            this._reviewService = reviewService;
        }

        // GET: api/<ReviewController>
        [HttpGet]
        public ActionResult<IEnumerable<Review>> Get()
        {
            //return OK(new Review[] { new Review(), new Review() });
            var review= _reviewService.GetReviews();
            if (review.Any())
            {
                return Ok(review);
            }
            else
            {
                return NotFound();
            }

            // return Ok(_reviewService.GetReviews());
        }
        // GET api/Review/5
        //[HttpGet("Rating/5")]
        //public ActionResult<IEnumerable<Review>> GetReviewsByRating5()
        //{
        //    var reviews5 = _reviewService.GetReviews()
        //                            .Where(m => m.Rating > Rating).ToList();
        //    if (Ratings5.Any())
        //    {
        //        return Ok(ratings5);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}

        //[HttpGet("rating/{rating}")]
        //public ActionResult<IEnumerable<Review>> GetReviewsBy5(string rating)
        //{
        //    var reviewsByRating = _reviewService.GetReviews()
        //                                               .Where(m => m.Rating == rating)
        //                                               .ToList();

        //    return reviewsByRating.Any() ? Ok(reviewsByRating) : NotFound();
        //}

        [HttpGet("rating/{rating}")]
        public ActionResult<List<Review>> GetByRating(int rating)
        {
            if (rating == 0)
            {
                return BadRequest();
            }
            else
            {
                var ratings = _reviewService.GetReviewsRatings(rating);
                if (ratings != null && ratings.Any())
                {
                    return Ok(ratings);
                }
                else
                {
                    return NotFound();
                }
            }

        }

        // GET api/<ReviewController>/5
        [HttpGet("id{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReviewController>
        [HttpPost]
        public IActionResult Post([FromBody] Review value)
        {
            return Ok();
        }

        // PUT api/<ReviewController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Review value)
        {
            return Ok();
        }

        // DELETE api/<ReviewController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}

