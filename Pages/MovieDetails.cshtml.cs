using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project6ASP.NETCoreRazorPages.Services;

namespace Project6ASP.NETCoreRazorPages.Pages
{
    public class MovieDetailsModel : PageModel
    {

        public IMovieService _movieService;

        public Movie ExistingMovie { get; set; } 

        public MovieDetailsModel(IMovieService movieService)
        {
            _movieService = movieService;
        }


        public IActionResult OnGet(Guid Id)
        {
            ExistingMovie = _movieService.GetById(Id);
            return Page();
        }

    }
}
