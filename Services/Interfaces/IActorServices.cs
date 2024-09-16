using MoviesAPI3.Models;

namespace MoviesAPI3.Services.Interfaces
{
    public interface IActorServices
    {
       
        List<Actor> GetActorByRoltype(String rolType);
        Actor GetActorByName(String name);
        List<Actor> GetActorByActingExperience(String rolType);
        void DeleteActorByName(string name);

        Actor GetActorById(Guid id);
        void DeleteActor(Guid id);



    }
}
