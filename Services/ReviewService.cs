using MoviesAPI3.Models;
using MoviesAPI3.Repositories;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Services.Interfaces;

namespace MoviesAPI3.Services
{
    public class ReviewService : IReviewServices
    {
        private IReviewRepository _reviewRepositori;
        public ReviewService(IReviewRepository reviewRepositori)
        {
            _reviewRepositori = reviewRepositori;
        }
        public List<Review> GetReviewsRatings(int rating)
        {
            var reviews = _reviewRepositori.GetReviews();
            return reviews.Where(c => c.Rating == rating).ToList();
        }
        public List<Review> GetReviews()
        {
            return _reviewRepositori.GetReviews();
        }
    }
}
