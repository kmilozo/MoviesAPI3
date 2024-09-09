using MoviesAPI3.Models;

namespace MoviesAPI3.Services.Interfaces
{
    public interface IReviewServices
    {
        List<Review> GetReviewsRatings(int rating);
        List<Review> GetReviews();
    }
}
