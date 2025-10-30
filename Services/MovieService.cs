namespace Project6ASP.NETCoreRazorPages.Services
{
    public class MovieService : IMovieService
    {
        public static List<Movie> _movielist { get; set; } = new();

        public List<Movie> GetAllMovies()
        {
            return _movielist;
        }



        
    }
}
