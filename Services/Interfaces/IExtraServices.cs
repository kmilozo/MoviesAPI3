using MoviesAPI3.Models;

namespace MoviesAPI3.Services.Interfaces
{
    public interface IExtraServices
    {
       
        List<Extra> GetExtraByRoltype(String rolType);
        Extra GetExtraByName(String name);
        List<Extra> GetExtraByIsStuntDouble(String rolType);
        void DeleteExtraByName(string name);

        Extra GetExtraById(Guid id);
        void DeleteExtra(Guid id);



    }
}
