﻿using System.Reflection;

namespace Project6ASP.NETCoreRazorPages.Services
{
    public class Movie
    {
        public Movie(string title, int year, string director)
        {
            Title = title;
            Year = year;
            Director = director;
            
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }

        




    }
}
