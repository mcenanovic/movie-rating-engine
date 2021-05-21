using Microsoft.AspNetCore.Mvc;
using MovieRatingEngine.Core.MovieManagement.Models;
using MovieRatingEngine.Core.MovieManagement.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieRatingEngine.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieRepository movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
        }

        [HttpGet]
        public async Task<List<MovieListItem>> Get([FromQuery] GetMoviesQuery query)
        {
            return await movieRepository.GetMoviesAsync(query.IsMovie, query.Search, query.Count);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] int rating)
        {
            if (id == null || !(await movieRepository.MovieExistsAsync(id)))
            {
                return NotFound();
            }

            await movieRepository.UpdateMovieAsync(id, rating);

            return Ok();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class GetMoviesQuery
    {
        public bool IsMovie { get; set; }

        public string Search { get; set; }

        public int Count { get; set; }
    }
}
