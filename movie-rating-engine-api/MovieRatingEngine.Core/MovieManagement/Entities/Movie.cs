using MovieRatingEngine.Core.MovieManagement.Entities;
using System;
using System.Collections.Generic;

namespace MovieRatingEngine.Core.MovieManagement.Entities
{
    public class Movie
    {
        public int MovieID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int VoteCount { get; set; }

        public decimal Rating { get; set; }

        public List<MovieActor> Actors { get; set; }

        public string ImageName { get; set; }
    }
}
