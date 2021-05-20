using System;
using System.Collections.Generic;

namespace MyPro.Core.UserManagement.Models
{
    public class MovieListItem
    {
        public string Title { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Rating { get; set; }

        public List<string> Actors { get; set; }
    }
}
