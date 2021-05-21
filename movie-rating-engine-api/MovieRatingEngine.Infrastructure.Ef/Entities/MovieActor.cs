using MovieRatingEngine.Infrastructure.Ef.Entities;

namespace MovieRatingEngine.Infrastructure.Ef.Entities
{
    internal class MovieActor
    {
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        public int ActorID { get; set; }
        public Actor Actor { get; set; }
    }
}
