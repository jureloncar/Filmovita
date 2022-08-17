using Filmovita.Entity;
using Filmovita.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Filmovita.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly MovieContext _dbContext;
        private Review mappedReviews;

        public ReviewController(MovieContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<ActionResult<Review>> AddReview(CreateReview review)
        {
            var movie = await _dbContext.Movies.Include(x=> x.Reviews).FirstOrDefaultAsync(x => x.Id == review.MovieId);
            if (movie == null)
            {
                return NotFound("Movie was not found");
            }

            var mappedReview = Map(review);
            movie.Reviews.Add(mappedReview);
            await  _dbContext.SaveChangesAsync();

            return Ok(mappedReview);
        }

        private Review Map(CreateReview review)
        {
            return new Review
            {
                Reviews = review.Review,
                Movie = new Movie
                {
                    Id = review.MovieId
                }
            };
        }
    }
}
