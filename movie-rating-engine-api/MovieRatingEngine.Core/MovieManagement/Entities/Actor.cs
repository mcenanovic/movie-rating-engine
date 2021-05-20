using System.Collections.Generic;

namespace MovieRatingEngine.Core.MovieManagement.Entities
{
    public class Actor
    {
        public int ActorID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<MovieActor> Movies { get; set; }
    }
}
