using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace Project6ASP.NETCoreRazorPages.Pages
{
    public class OverviewModel : PageModel
    {
        public List<string> Title1 {  get; set; } = new List<string>();
        public List<string> Year1 { get; set; } = new List<string>();
        public List<string> Director1 { get; set; } = new List<string>();

        public OverviewModel(string title, int year, string director)
        {
            Title = title;

            Year = year;

            Director = director;
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }


        public void OnGet()
        {

            //OverviewModel JohnWick = new OverviewModel("John Wick", 2014, "Chad Stahelski");
            //OverviewModel JohnWick2 = new OverviewModel("John Wick 2", 2017, "Chad Stahelski");
            //OverviewModel JohnWick3 = new OverviewModel("John Wick 3", 2019, "Chad Stahelski");
            //OverviewModel JohnWick4 = new OverviewModel("John Wick 4", 2023, "Chad Stahelski");
            //OverviewModel Ballerina = new OverviewModel("Ballerina", 2025, "Len Wiseman");


            Title1.Add("John Wick");
            Title1.Add("John Wick 2");
            Title1.Add("John Wick 3");
            Title1.Add("John Wick 4");
            Title1.Add("Ballerina");

            Year1.Add("2014");
            Year1.Add("2017");
            Year1.Add("2019");
            Year1.Add("2023");
            Year1.Add("2025");

            Director1.Add("Chad Stahelski");
            Director1.Add("Chad Stahelski");
            Director1.Add("Chad Stahelski");
            Director1.Add("Chad Stahelski");
            Director1.Add("Len Wiseman");
        }
    }
}
