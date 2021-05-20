using MyPro.Core.UserManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPro.Core.UserManagement.Repositories
{
	//Test
    public interface IMovieRepository
    {
        Task<List<MovieListItem>> GetMoviesAsync();
    }
}
