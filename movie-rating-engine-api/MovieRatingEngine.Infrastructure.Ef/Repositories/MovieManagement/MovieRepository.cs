using LinqKit;
using Microsoft.EntityFrameworkCore;
using MovieRatingEngine.Core.MovieManagement.Models;
using MovieRatingEngine.Core.MovieManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MovieRatingEngine.Infrastructure.Ef.Repositories.MovieManagement
{
    internal class MovieRepository : IMovieRepository
    {
        private MovieRatingEngineDbContext dbContext;

        public MovieRepository(MovieRatingEngineDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<MovieListItem>> GetMoviesAsync(bool isMovie, string search, int count)
        {
            try
            {
                return await dbContext.Movies
                    .Where(ProcessSearchString(search))
                    .Where(x => x.IsMovie == isMovie)
                    .Select(x => new MovieListItem
                    {
                        MovieID = x.MovieID,
                        Title = x.Title,
                        Description = x.Description,
                        ReleaseDate = x.ReleaseDate,
                        Rating = x.Rating,
                        Actors = x.Actors.Select(a => a.Actor.FirstName + " " + a.Actor.LastName).ToList(),
                        ImageName = x.ImageName
                    })
                    .OrderByDescending(x => x.Rating)
                    .Take(count)
                    .ToListAsync();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Task UpdateMovieAsync(int id, int rating)
        {
            return Task.Run(() =>
            {
                var movie = dbContext.Movies
                    .FirstOrDefault(x => x.MovieID == id);

                if (movie == null)
                {
                    return;
                }

                var totalRating = movie.VoteCount * movie.Rating;

                movie.VoteCount++;
                movie.Rating = (totalRating + rating) / movie.VoteCount;

                dbContext.Update(movie);
                dbContext.SaveChanges();
            });
        }

        public Task<bool> MovieExistsAsync(int id)
        {
            return dbContext.Movies.AnyAsync(x => x.MovieID == id);
        }

        private static Expression<Func<Entities.Movie, bool>> ProcessSearchString(string searchInput)
        {
            var predicateBuilder = PredicateBuilder.New<Entities.Movie>();

            if (string.IsNullOrEmpty(searchInput))
            {
                return predicateBuilder.Or(x => true);
            }

            var ratingValues = new List<char> { '1', '2', '3', '4', '5' };
            var search = searchInput.ToLower();

            if (search.EndsWith(" stars") && int.TryParse(search.Substring(0, 1), out int rating))
            {
                if (rating >= 1 && rating <= 5)
                {
                    predicateBuilder = predicateBuilder.Or(x => x.Rating == rating);
                }
            }
            else if (search.StartsWith("at least ") && search.EndsWith(" stars") && ratingValues.Contains(search[9]))
            {
                if (int.TryParse(search[9].ToString(), out rating))
                {
                    predicateBuilder = predicateBuilder.Or(x => x.Rating >= rating);
                }
            }
            else if (search.StartsWith("after ") && int.TryParse(search.Substring(search.Length - 4), out int releaseYear))
            {
                if (releaseYear <= 2021 && releaseYear > 1920)
                {
                    predicateBuilder = predicateBuilder.Or(x => x.ReleaseDate.Year >= releaseYear);
                }
            }
            else if (search.StartsWith("older than ") && search.EndsWith("years") && int.TryParse(search.Substring(11, search.Length - 16), out int years))
            {
                if (years <= 100 && years >= 0)
                {
                    predicateBuilder = predicateBuilder.Or(x => x.ReleaseDate < DateTime.Now.AddYears(-years));
                }
            }
            else
            {
                predicateBuilder = predicateBuilder.Or(x => x.Title.ToLower().Contains(search) || x.Description.ToLower().Contains(search));
            }

            return predicateBuilder;
        }
    }
}
