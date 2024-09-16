using MoviesAPI3.Models;
using MoviesAPI3.Repositories.Interfaces;
using MoviesAPI3.Utilities;
using System.Drawing;

namespace MoviesAPI3.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly List<Actor> _actors;
        public ActorRepository()
        {
            _actors = new List<Actor>()
            {
               new Actor()
               {
                    Id = Guid.NewGuid(),
                    Name = "Daniela",
                    Age = 29,
                    Nationality="Ftancia",
                    RolType ="Actriz de reparto",
                    ActingExperience = "7 años"

               },
                new Actor()
               {
                    Id = Guid.NewGuid(),
                    Name = "Valeria",
                    Age = 25,
                    Nationality="Colombia",
                    RolType ="Actriz Protagonista",
                    ActingExperience = "20 años"

               },
                 new Actor()
               {
                    Id = Guid.NewGuid(),
                    Name = "Cristian",
                    Age = 30,
                    Nationality="Colombia",
                    RolType ="Actor de reparto",
                    ActingExperience = "10 años"

               },
            };
        }

        public void DeleteActor(Actor actor)
        {
            _actors.Remove(actor);
        }


        public Actor GetActorById(Guid id)
        {
            // Buscar en la lista _aerials el objeto con el ID especificado
            return _actors.FirstOrDefault(a => a.Id == id);
        }

        public List<Actor> GetActors()
        {
            return _actors;
        }
    }
}
