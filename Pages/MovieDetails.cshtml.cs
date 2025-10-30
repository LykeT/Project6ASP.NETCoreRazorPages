using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project6ASP.NETCoreRazorPages.Services;

namespace Project6ASP.NETCoreRazorPages.Pages
{
    public class MovieDetailsModel : PageModel
    {

        public IMovieService _movieService;

        public List<Movie> Movies { get; set; }

        public MovieDetailsModel(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public List<Movie> MovieList { get; set; } = new();

        public void OnGet()
        {
            MovieList.AddRange(MovieService._movielist);

            Movies = _movieService.GetAllMovies();
        }
            
    }
}
