using MovieRatingEngine.Core.MovieManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieRatingEngine.Core.MovieManagement.Repositories
{
    public interface IMovieRepository
    {
        Task<List<MovieListItem>> GetMoviesAsync(bool isMovie, string search, int count);

        Task UpdateMovieAsync(int id, int rating);

        Task<bool> MovieExistsAsync(int id);
    }
}
