using MoviesAPI3.Models;
using MoviesAPI3.Repositories;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Services;
using MoviesAPI3.Services.Interfaces;
using System.Xml.Linq;

namespace MoviesAPI3.Services
{
    public class ActorService : IActorServices
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public void DeleteActor(Guid id)
        {

            var actor = _actorRepository.GetActors()
                                         .FirstOrDefault(a => a.Id == id);
            if (actor != null)
            {
                _actorRepository.DeleteActor(actor);
            }
        }

        public void DeleteActorByName(string name)
        {
            var actor = GetActorByName(name);
            if (actor != null)
            {
                _actorRepository.DeleteActor(actor);
            }
        }

        public List<Actor> GetActorByActingExperience(string rolType)
        {
            return _actorRepository.GetActors()
                            .Where(a => a.Name.ToLower() == rolType.ToLower())
                            .ToList();
        }

        public Actor GetActorById(Guid id)
        {
            
            return _actorRepository.GetActors()
                                     .FirstOrDefault(a => a.Id == id);
        }

        public Actor GetActorByName(string name)
        {
            return _actorRepository.GetActors()
                                    .FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
        }

        public List<Actor> GetActorByRoltype(string rolType)
        {
            return _actorRepository.GetActors()
                           .Where(a => a.RolType.ToLower() == rolType.ToLower())
                           .ToList();
        }
    }
}


















