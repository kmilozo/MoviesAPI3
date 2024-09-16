using MoviesAPI3.Models;
using MoviesAPI3.Repositories;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Services;
using MoviesAPI3.Services.Interfaces;
using System.Xml.Linq;

namespace MoviesAPI3.Services
{
    public class ExtraService : IExtraServices
    {
        private readonly IExtraRepository _extraRepository;

        public ExtraService(IExtraRepository extraRepository)
        {
            _extraRepository = extraRepository;
        }
        public void DeleteExtra(Guid id)
        {
            var extra = _extraRepository.GetExtras()
                               .FirstOrDefault(a => a.Id == id);
            if (extra != null)
            {
                _extraRepository.DeleteExtra(extra);
            }
        }

        public void DeleteExtraByName(string name)
        {
            var extra = GetExtraByName(name);
            if (extra != null)
            {
                _extraRepository.DeleteExtra(extra);
            }
        }

        public Extra GetExtraById(Guid id)
        {
            return _extraRepository.GetExtras()
                            .FirstOrDefault(a => a.Id == id);
        }

        public List<Extra> GetExtraByIsStuntDouble(string rolType)
        {
            return _extraRepository.GetExtras()
                   .Where(a => a.Name.ToLower() == rolType.ToLower())
                   .ToList();
        }

        public Extra GetExtraByName(string name)
        {
            return _extraRepository.GetExtras()
                           .FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
        }

        public List<Extra> GetExtraByRoltype(string rolType)
        {
            return _extraRepository.GetExtras()
                    .Where(a => a.RolType.ToLower() == rolType.ToLower())
                    .ToList();
        }
    }
}























