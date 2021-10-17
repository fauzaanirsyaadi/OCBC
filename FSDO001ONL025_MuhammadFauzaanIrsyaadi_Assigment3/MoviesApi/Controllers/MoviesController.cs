using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Data;
using Movies.Models;
using System;
using System.Linq;

namespace Movies.Controllers
{
    [Route("api/[controller]")]//api/todo
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }

        [HttpGet] //all
        public async Task<IActionResult> GetAllMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return Ok(movies);
        }

        [HttpGet("{id}")] //specific id
        public async Task<IActionResult> GetMovie(int id)
        {
            var item = await _context.Movies.FirstOrDefaultAsync(x => x.id == id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpGet("GetAct/{act}")] //movie active or not
        public async Task<IActionResult> GetMovieActive(bool act)
        {
            var item = await _context.Movies.Where(x => x.act == act).ToListAsync();

            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]//insert
        public async Task<IActionResult> InsertMovies(MovieData movie)
        {
            if (ModelState.IsValid)
            {
                await _context.Movies.AddAsync(movie);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetAllMovies", new { movie.id }, movie);
            }

            return new JsonResult("Data gk ada") { StatusCode = 500 };
        }

        [HttpPut("{id}")]//update
        public async Task<IActionResult> UpdateItem(int id, MovieData movie)
        {
            if (id != movie.id)
                return BadRequest();

            var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.id == id);

            if (existItem == null)
                return NotFound();

            existItem.Name = movie.Name;
            existItem.genre = movie.genre;
            existItem.duration = movie.duration;
            existItem.ReleaseDate = movie.ReleaseDate;
            existItem.price = movie.price;
            existItem.act = movie.act;

            await _context.SaveChangesAsync();

            return new JsonResult("Data Updates") { StatusCode = 201 };
        }

        [HttpDelete("{id}")]//delete
        public async Task<IActionResult> DeleteItem(int id)
        {
            var existItem = await _context.Movies.FirstOrDefaultAsync(x => x.id == id);

            if (existItem == null)
                return NotFound();

            _context.Movies.Remove(existItem);
            await _context.SaveChangesAsync();

            return new JsonResult("Data Deleted") { StatusCode = 201 };
        }



    }
}