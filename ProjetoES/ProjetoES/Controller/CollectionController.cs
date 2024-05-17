using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoES.Data;
using ProjetoES.Models;

namespace ProjetoES.Controller
{
    [Route("api/[controller")]
    public class CollectionController:ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CollectionController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetDbMovies()
        {
            var favourites = await _context.Favourites.FirstOrDefaultAsync();
            if (favourites == null)
            {
                return NotFound("O utilizador não tem favoritos");
            }
            var movies = favourites.Movies;
            return Ok(movies);
        }
        [HttpPost]
        public async Task<ActionResult> AddMovie(Movie movie)
        {
            var favourite = await _context.Favourites.FirstOrDefaultAsync();
            if (favourite == null) {
                return NotFound();
            }
            favourite.Movies.Add(movie);
            _context.Favourites.Update(favourite);
            await _context.SaveChangesAsync();

            return Ok(favourite);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteMovie(int id)
        {
            var favourite = await _context.Favourites.FirstOrDefaultAsync();
            var movie = favourite.Movies.FirstOrDefault(it => it.Id == it.Id);
            if(favourite.Movies == null)
            {
                return NotFound();
            }
            favourite.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return Ok(await GetDbMovies());
        }
    }
}
