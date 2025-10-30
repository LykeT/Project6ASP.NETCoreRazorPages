// Extensions/SeedDataExtensions.cs

using Microsoft.Extensions.DependencyInjection;
using Project6ASP.NETCoreRazorPages.Pages;
using Project6ASP.NETCoreRazorPages.Services;

public static class SeedDataExtensions
{
    public static void InitSeedData(this IServiceCollection services)
    {
        MovieService._movielist.AddRange(new List<Movie> {
     new Movie("Title 1", 2015, "Director 1"),
     new Movie("Title 2", 2019, "Director 2"),
     new Movie("Title 3", 2020, "Director 3"),
     new Movie("Title 3", 2020, "Director 3"),
     new Movie("Title 3", 2020, "Director 3"),
     new Movie("Title 3", 2020, "Director 3"),
     new Movie("Title 3", 2020, "Director 3"),
     new Movie("Title 3", 2020, "Director 3"),
     new Movie("Title 3", 2020, "Director 3"),
     new Movie("Title 3", 2020, "Director 3")
    });
    }
}