using MoviesAPI3.Models;

namespace MoviesAPI3.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        List<Review> GetReviews();
    }
}
