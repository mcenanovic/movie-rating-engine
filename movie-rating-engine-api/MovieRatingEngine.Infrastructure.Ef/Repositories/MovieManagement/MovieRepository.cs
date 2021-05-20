using Microsoft.EntityFrameworkCore;
using MyPro.Core.UserManagement.Entities;
using MyPro.Core.UserManagement.Models;
using MyPro.Core.UserManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPro.Infrastructure.Ef.Repositories.UserManagement
{
    internal class MovieRepository : IMovieRepository
    {
        private MyProDbContext dbContext;

        public MovieRepository(MyProDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<Movie> GetUserByIdAsync(Guid id)
        {
            return dbContext.Users
                .Where(x => x.Id == id)
                .Select(x => new Movie
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                })
                .FirstOrDefaultAsync();
        }

        public Task<List<MovieListItem>> GetUsersAsync()
        {
            return dbContext.Users
               .Select(x => new MovieListItem
               {
                   Id = x.Id,
                   FirstName = x.FirstName,
               })
               .ToListAsync();
        }

        public Task<Guid> CreateUserAsync(Movie user)
        {
            return Task.Run(() =>
            {
                var userDbEntity = new Entities.Movie
                {
                    Id = Guid.NewGuid(),
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                };

                dbContext.Users.Add(userDbEntity);
                dbContext.SaveChanges();

                return userDbEntity.Id;
            });
        }

        public Task UpdateUserAsync(Movie user)
        {
            return Task.Run(() =>
            {
                var dbUser = dbContext.Users.FirstOrDefault(x => x.Id == user.Id);
                if (dbUser != null)
                {
                    dbUser.FirstName = user.FirstName;
                    dbUser.LastName = user.LastName;

                    dbContext.Users.Update(dbUser);
                    dbContext.SaveChanges();
                }
            });
        }

        public Task DeleteUserAsync(Guid id)
        {
            return Task.Run(() =>
            {
                var user = this.dbContext.Users.FirstOrDefault(x => x.Id == id);
                if (user != null)
                {
                    this.dbContext.Remove(user);
                    this.dbContext.SaveChanges();
                }
            });
        }

        public Task<bool> UserExistsAsync(Guid id)
        {
            return this.dbContext.Users.AnyAsync(x => x.Id == id);
        }
    }
}
