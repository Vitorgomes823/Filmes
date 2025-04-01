using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class MoviesController : ControllerBase
{
    private readonly TmdbService _tmdbService;

    public MoviesController()
    {
        _tmdbService = new TmdbService();
    }

    [HttpGet("popular")]
    public async Task<IActionResult> GetPopularMovies()
    {
        var movies = await _tmdbService.GetPopularMoviesAsync();
        return Ok(movies);
    }
}
