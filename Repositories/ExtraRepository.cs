using MoviesAPI3.Models;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Utilities;
using System.Drawing;

namespace MoviesAPI3.Repositories
{
    public class ExtraRepository : IExtraRepository
    {
        private readonly List<Extra> _extras;
        public ExtraRepository()
        {
            _extras = new List<Extra>()
            {
               new Extra()
               {

                    Id = Guid.NewGuid(),
                    Name = "Miguel",
                    Age = 29,
                    Nationality="Inglaterra",
                    RolType ="Doble de riesgo",
                    IsStuntDouble = true

               },
               new Extra()
               {

                    Id = Guid.NewGuid(),
                    Name = "Quique",
                    Age = 50,
                    Nationality="Francia",
                    RolType ="Doble",
                    IsStuntDouble = false

               },
               new Extra()
               {

                    Id = Guid.NewGuid(),
                    Name = "Velinda",
                    Age = 90,
                    Nationality="Rusa",
                    RolType ="Doble de riesgo",
                    IsStuntDouble = true

               }

            };
        }

        public void DeleteExtra(Extra extra)
        {
            _extras.Remove(extra);
        }


        public Extra GetExtraById(Guid id)
        {
            // Buscar en la lista _aerials el objeto con el ID especificado
            return _extras.FirstOrDefault(a => a.Id == id);
        }

        public List<Extra> GetExtras()
        {
            return _extras;
        }
    }
}
