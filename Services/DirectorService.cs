using MoviesAPI3.Models;
using MoviesAPI3.Repositories;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Services.Interfaces;

namespace MoviesAPI3.Services
{
    public class DirectorService : IDirectorServices
    {
        private IDirectorRepository _directorRepositori;
        public DirectorService(IDirectorRepository directorRepositori)
        {
            _directorRepositori = directorRepositori;
        }
        public List<Director> GetDirectorsNationalitys(string nationality)
        {
            var directors = _directorRepositori.GetDirectors();
            return directors.Where(c => c.Nationality == nationality).ToList();
        }
        public List<Director> GetDirectors()
        {
            return _directorRepositori.GetDirectors();
        }
    }
}
