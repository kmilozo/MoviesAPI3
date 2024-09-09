using MoviesAPI3.Models;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Utilities;
using System.Drawing;

namespace MoviesAPI3.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        public List<Director> GetDirectors()
        {
            return new List<Director>()
            {
                new Director() { Id = 1, Name = "Steven Spielberg", DateOfBirth = new DateTime(1946, 12, 18), Nationality = "American" },
                new Director() {  Id = 2, Name = "Christopher Nolan", DateOfBirth = new DateTime(1970, 7, 30), Nationality = "British-American" },
                new Director() { Id = 3, Name = "Martin Scorsese", DateOfBirth = new DateTime(1942, 11, 17), Nationality = "American" },
                new Director() { Id = 4, Name = "Quentin Tarantino", DateOfBirth = new DateTime(1963, 3, 27), Nationality = "American" },
                new Director() { Id = 5, Name = "James Cameron", DateOfBirth = new DateTime(1954, 8, 16), Nationality = "Canadian" },
                new Director() { Id = 6, Name = "Sofia Coppola", DateOfBirth = new DateTime(1971, 5, 14), Nationality = "American" },
            };
        }
    }
}
