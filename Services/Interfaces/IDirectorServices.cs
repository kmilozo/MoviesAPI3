using MoviesAPI3.Models;

namespace MoviesAPI3.Services.Interfaces
{
    public interface IDirectorServices
    {
        List<Director> GetDirectorsNationalitys(string nationality);
        List<Director> GetDirectors();
    }
}
