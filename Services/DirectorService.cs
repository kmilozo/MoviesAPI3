using MoviesAPI3.Models;
using MoviesAPI3.Repositories;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Services.Interfaces;

namespace MoviesAPI3.Services
{
    public class DirectorService : IDirectorServices
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }

        public void DeleteDirector(Guid id)
        {

            var director = _directorRepository.GetDirectors()
                                         .FirstOrDefault(a => a.Id == id);
            if (director != null)
            {
                _directorRepository.DeleteDirector(director);
            }
        }

        public void DeleteDirectorByName(string name)
        {
            var director = GetDirectorByName(name);
            if (director != null)
            {
                _directorRepository.DeleteDirector(director);
            }
        }

        public List<Director> GetDirectorByVisualStyle(string rolType)
        {
            return _directorRepository.GetDirectors()
                            .Where(a => a.Name.ToLower() == rolType.ToLower())
                            .ToList();
        }

        public Director GetDirectorById(Guid id)
        {

            return _directorRepository.GetDirectors()
                                     .FirstOrDefault(a => a.Id == id);
        }

        public Director GetDirectorByName(string name)
        {
            return _directorRepository.GetDirectors()
                                    .FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
        }

        public List<Director> GetDirectorByRoltype(string rolType)
        {
            return _directorRepository.GetDirectors()
                           .Where(a => a.RolType.ToLower() == rolType.ToLower())
                           .ToList();
        }
    }
}
