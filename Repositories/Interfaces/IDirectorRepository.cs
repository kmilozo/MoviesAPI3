using MoviesAPI3.Models;

namespace MoviesAPI3.Repositories.Interfaces
{
    public interface IDirectorRepository
    {
        List<Director> GetDirectors();
        Director GetDirectorById(Guid id);  // Método para obtener una entidad "Aerial" por ID
        void DeleteDirector(Director director);
    }
}
