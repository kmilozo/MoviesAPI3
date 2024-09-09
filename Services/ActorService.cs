using MoviesAPI3.Models;
using MoviesAPI3.Repositories;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Services.Interfaces;

namespace MoviesAPI3.Services
{
    public class ActorService : IActorServices
    {
        private IActorRepository _actorRepository;
        public ActorService(IActorRepository actorRepository) 
        {
            _actorRepository = actorRepository;
        }
        public List<Actor> GetActorByDateOfBirth(DateTime dateofbirth)
        {
            var actors = _actorRepository.GetActors();
            return actors.Where(c => c.DateOfBirth == dateofbirth).ToList();
        }
        public List<Actor> GetActors()
        {
            return _actorRepository.GetActors();
        }
    }
}
