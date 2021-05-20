using Microsoft.EntityFrameworkCore;
using MovieRatingEngine.Infrastructure.Ef;
using MyPro.Core.UserManagement.Models;
using MyPro.Core.UserManagement.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPro.Infrastructure.Ef.Repositories.UserManagement
{
    internal class MovieRepository : IMovieRepository
    {
        private MovieRatingEngineDbContext dbContext;

        public MovieRepository(MovieRatingEngineDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<MovieListItem>> GetMoviesAsync()
        {
            return await dbContext.Movies
                .Select(x => new MovieListItem
                {
                    Title = x.Title,
                    Description = x.Description,
                    ImageURL = x.ImageURL,
                    ReleaseDate = x.ReleaseDate,
                    Rating = x.Rating,
                    Actors = x.Actors.Select(a => a.Actor.FirstName + " " + a.Actor.LastName).ToList()
                })
                .OrderByDescending(x => x.Rating)
                .ToListAsync();
        }
    }
}
