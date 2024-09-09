using MoviesAPI3.Models;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Utilities;
using System.Drawing;

namespace MoviesAPI3.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        public List<Review> GetReviews() 
        { 
            return new List<Review>()
            {
                new Review() { Id = 1, MovieId = 1, Title = "Iron Man", ReviewerName = "John Doe", Comment = "An amazing start to the Marvel Cinematic Universe!", Rating = 5, ReviewDate = new DateTime(2008, 5, 5) },
                new Review() { Id = 2, MovieId = 2, Title = "The Dark Knight", ReviewerName = "Jane Smith", Comment = "One of the best superhero movies ever made.", Rating = 5, ReviewDate = new DateTime(2008, 7, 20) },
                new Review() { Id = 3, MovieId = 3, Title = "Titanic", ReviewerName = "Mark Johnson", Comment = "A timeless love story with stunning visuals.", Rating = 4, ReviewDate = new DateTime(1997, 12, 19) },
                new Review() { Id = 4, MovieId = 4, Title = "Pulp Fiction", ReviewerName = "Emily Davis", Comment = "A masterpiece of non-linear storytelling.", Rating = 5, ReviewDate = new DateTime(1994, 10, 14) },
                new Review() { Id = 5, MovieId = 5, Title = "Avatar", ReviewerName = "Chris Wilson", Comment = "A visually stunning film with a great message.", Rating = 4, ReviewDate = new DateTime(2009, 12, 18) },
                new Review() { Id = 6, MovieId = 6, Title = "Lost in Translation", ReviewerName = "Anna Brown", Comment = "A beautiful and subtle exploration of loneliness.", Rating = 4, ReviewDate = new DateTime(2003, 9, 12) },

            };
        }
    }
}
