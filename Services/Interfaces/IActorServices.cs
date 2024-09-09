using MoviesAPI3.Models;

namespace MoviesAPI3.Services.Interfaces
{
    public interface IActorServices
    {
        List<Actor> GetActorByDateOfBirth(DateTime dateofbirth);
        List<Actor> GetActors();
    }
}
