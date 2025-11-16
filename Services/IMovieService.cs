using Microsoft.AspNetCore.Mvc;
using Project6ASP.NETCoreRazorPages.Models;

namespace Project6ASP.NETCoreRazorPages.Services
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        void AddMovie(Movie newMovie);




    }
}
