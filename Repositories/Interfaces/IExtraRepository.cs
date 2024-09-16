using MoviesAPI3.Models;
using System.Reflection.Metadata.Ecma335;

namespace MoviesAPI3.Repositories.Interfaces
{
    public interface IExtraRepository
    {
        List<Extra> GetExtras();
        Extra GetExtraById(Guid id);  // Método para obtener una entidad "Aerial" por ID
        void DeleteExtra(Extra extra);

    }
}
