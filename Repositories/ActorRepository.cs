using MoviesAPI3.Models;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Utilities;
using System.Drawing;

namespace MoviesAPI3.Repositories
{
    public class ActorRepository : IActorRepository
    {
        public List<Actor> GetActors()
        {
            return new List<Actor>()
            {
                new Actor() { Id = 1, Name = "Robert Downey Jr.", DateOfBirth = new DateTime(1965, 4, 4), Nationality = "American" },
                new Actor() { Id = 2, Name = "Scarlett Johansson", DateOfBirth = new DateTime(1984, 11, 22), Nationality = "American" },
                new Actor() { Id = 3, Name = "Chris Hemsworth", DateOfBirth = new DateTime(1983, 8, 11), Nationality = "Australian" },

                new Actor() { Id = 4, Name = "Tom Hanks", DateOfBirth = new DateTime(1956, 7, 9), Nationality = "American" },
                new Actor() { Id = 5, Name = "Natalie Portman", DateOfBirth = new DateTime(1981, 6, 9), Nationality = "Israeli-American" },
                new Actor() { Id = 6, Name = "Daniel Radcliffe", DateOfBirth = new DateTime(1989, 7, 23), Nationality = "British" },
            };
        }
    }
}
