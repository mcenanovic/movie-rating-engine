using MyPro.Core.UserManagement.Entities;
using MyPro.Core.UserManagement.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyPro.Core.UserManagement.Repositories
{
	//Test
    public interface IMovieRepository
    {
        Task<Movie> GetUserByIdAsync(Guid id);

        Task<List<MovieListItem>> GetUsersAsync();

        Task<Guid> CreateUserAsync(Movie user);

        Task UpdateUserAsync(Movie user);

        Task DeleteUserAsync(Guid id);

        Task<bool> UserExistsAsync(Guid id);
    }
}
