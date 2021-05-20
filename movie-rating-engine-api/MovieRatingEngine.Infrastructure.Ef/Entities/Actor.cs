using MyPro.Infrastructure.Ef.Entities;
using System.Collections.Generic;

namespace MovieRatingEngine.Infrastructure.Ef.Entities
{
    internal class Actor
    {
        public int ActorID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<MovieActor> Movies { get; set; }
    }
}
