using MovieRatingEngine.Infrastructure.Ef.Entities;
using System;
using System.Collections.Generic;

namespace MyPro.Infrastructure.Ef.Entities
{
    internal class Movie
    {
        public int MovieID { get; set; }

        public string Title { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int VoteCount { get; set; }

        public decimal Rating { get; set; }

        public List<MovieActor> Actors { get; set; }
    }
}
