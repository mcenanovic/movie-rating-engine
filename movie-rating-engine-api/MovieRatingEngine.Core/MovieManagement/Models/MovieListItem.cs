using System;
using System.Collections.Generic;

namespace MovieRatingEngine.Core.MovieManagement.Models
{
    public class MovieListItem
    {
        public int MovieID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Rating { get; set; }

        public List<string> Actors { get; set; }

        public string ImageName { get; set; }
    }
}
