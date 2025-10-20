using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Project6ASP.NETCoreRazorPages.Pages
{
    public class OverviewModel : PageModel
    {
        public List<string> Titlelist {  get; set; } = new List<string>();
        public List<string> Yearlist { get; set; } = new List<string>();
        public List<string> Directorlist { get; set; } = new List<string>();

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


            Titlelist.Add("John Wick");
            Titlelist.Add("John Wick 2");
            Titlelist.Add("John Wick 3");
            Titlelist.Add("John Wick 4");
            Titlelist.Add("Ballerina");

            Yearlist.Add("2014");
            Yearlist.Add("2017");
            Yearlist.Add("2019");
            Yearlist.Add("2023");
            Yearlist.Add("2025");

            Directorlist.Add("Chad Stahelski");
            Directorlist.Add("Chad Stahelski");
            Directorlist.Add("Chad Stahelski");
            Directorlist.Add("Chad Stahelski");
            Directorlist.Add("Len Wiseman");


            
        }
    }
}
