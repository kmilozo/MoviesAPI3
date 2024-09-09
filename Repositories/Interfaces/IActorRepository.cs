using MoviesAPI3.Models;
using System.Reflection.Metadata.Ecma335;

namespace MoviesAPI3.Repositories.Interfaces
{
    public interface IActorRepository
    {
        List<Actor> GetActors();


    }
}
