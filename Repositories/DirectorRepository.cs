using MoviesAPI3.Models;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Utilities;
using System.Drawing;

namespace MoviesAPI3.Repositories
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly List<Director> _directors;
        public DirectorRepository()
        {
            _directors = new List<Director>()
            {
               new Director()
               {
                    Id = Guid.NewGuid(),
                    Name = "Daniela",
                    Age = 29,
                    Nationality="Ftancia",
                    RolType ="Actriz de reparto",
                    VisualStyle = "7 años"

               },
                new Director()
               {
                    Id = Guid.NewGuid(),
                    Name = "Valeria",
                    Age = 25,
                    Nationality="Colombia",
                    RolType ="Actriz Protagonista",
                    VisualStyle = "20 años"

               },
                 new Director()
               {
                    Id = Guid.NewGuid(),
                    Name = "Cristian",
                    Age = 30,
                    Nationality="Colombia",
                    RolType ="Actor de reparto",
                    VisualStyle = "10 años"

               },
            };
        }

        public void DeleteDirector(Director director)
        {
            _directors.Remove(director);
        }


        public Director GetDirectorById(Guid id)
        {
            // Buscar en la lista _aerials el objeto con el ID especificado
            return _directors.FirstOrDefault(a => a.Id == id);
        }

        public List<Director> GetDirectors()
        {
            return _directors;
        }
    }
}
