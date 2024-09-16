using MoviesAPI3.Models;

namespace MoviesAPI3.Services.Interfaces
{
    public interface IDirectorServices
    {
        List<Director> GetDirectorByRoltype(String rolType);
        Director GetDirectorByName(String name);
        List<Director> GetDirectorByVisualStyle(String rolType);
        void DeleteDirectorByName(string name);

        Director GetDirectorById(Guid id);
        void DeleteDirector(Guid id);
    }
}
