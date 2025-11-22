using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project6ASP.NETCoreRazorPages.Models;
using Project6ASP.NETCoreRazorPages.Services;
using System.IO;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Project6ASP.NETCoreRazorPages.Pages
{
    public class OverviewModel : PageModel
    {

        public IMovieService _movieService;

        [BindProperty]
        public MovieView MovieInput { get; set; } = new();//For the form


        public OverviewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }


        public List<Movie> MovieList { get; set; } = new();// = new() IS setting a default value!!

        
        

        public void OnGet()
        {
            MovieList = _movieService.GetAllMovies();
            
            

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Return the same page to show validation messages
                return Page();
            }
            Movie newMovie = MovieInput.ToMovie();
            _movieService.AddMovie(newMovie);
            return RedirectToPage();//rerun the OnGet
        }
    }
}
/*

using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Project6ASP.NETCoreRazorPages.Pages
{
    public class OverviewModel : PageModel
    {
        // Three simple lists (beginner-friendly).
        public List<string> Titlelist { get; set; } = new List<string>();
        public List<int> Yearlist { get; set; } = new List<int>();
        public List<string> Directorlist { get; set; } = new List<string>();

        // Optional individual properties (not required, kept to match your original structure).
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }

        public void OnGet()
        {
            // Titles
            Titlelist.Add("John Wick");
            Titlelist.Add("John Wick 2");
            Titlelist.Add("John Wick 3");
            Titlelist.Add("John Wick 4");
            Titlelist.Add("Ballerina");

            // Years (as ints, not strings)
            Yearlist.Add(2014);
            Yearlist.Add(2017);
            Yearlist.Add(2019);
            Yearlist.Add(2023);
            Yearlist.Add(2025);

            // Directors
            Directorlist.Add("Chad Stahelski");
            Directorlist.Add("Chad Stahelski");
            Directorlist.Add("Chad Stahelski");
            Directorlist.Add("Chad Stahelski");
            Directorlist.Add("Len Wiseman");
        }
    }
}
*/