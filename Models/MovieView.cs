using Project6ASP.NETCoreRazorPages.Services;
using System.IO;

namespace Project6ASP.NETCoreRazorPages.Models
{
    public class MovieView
    {


        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Director { get; set; } = string.Empty;

        

    }

    public static class MovieViewMapper
    {
        public static Movie ToMovie(this MovieView newMovie)
        {

            return new Movie(newMovie.Title, newMovie.Year, newMovie.Director);
        }
    }
}
