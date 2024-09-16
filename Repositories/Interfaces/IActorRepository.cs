using MoviesAPI3.Models;
using System.Reflection.Metadata.Ecma335;

namespace MoviesAPI3.Repositories.Interfaces
{
    public interface IActorRepository
    {
        List<Actor> GetActors();
        Actor GetActorById(Guid id);  // Método para obtener una entidad "Aerial" por ID
        void DeleteActor(Actor actor);

    }
}
