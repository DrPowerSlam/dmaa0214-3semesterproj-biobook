using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Linq;
using ClientWebApp.CustomerServiceReference;
using ServerProject.DatabaseLayer;

namespace ClientWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");
            if (!IsPostBack)
            {
               //Page.RouteData.Values["movieID"]

                List<Movie> movieList = client.GetAllMovies();
                
                foreach(Movie movie in movieList)
                {

                    
                }
                
                //foreach(Movie movie in movieList)
                //{
                //    litNewstMovies.Text += movie.name + "<br/>";
                //}


                litNewstMovies.Text += "<div class=\"row\">";

                litNewstMovies.Text += "<div class=\"col-lg-12\">";

                litNewstMovies.Text += "<h3>" + "Nyeste film" + "</h3>";

                litNewstMovies.Text += "</div>";

                litNewstMovies.Text += "</div>";

                // Indhold af nyeste film, bliver udskrevet her..


                litNewstMovies.Text += "<div class=\"row text-center\">";

                foreach (Movie movie in movieList)
                {
                    foreach (Scheduler scheduler in movie.Schedulers)
                    {
                        //litNewstMovies.Text += scheduler.Movie.name;

                        litNewstMovies.Text += "";
                    
                        litNewstMovies.Text += "<div class=\"col-md-3 col-sm-6\">";
                        litNewstMovies.Text += "<div class=\"thumbnail\">";

                       // litNewstMovies.Text += "<a href=\"Resever/" + movie.MovieID + movie.name + "\"><img src='../../Content/Images/" + movie.Image + " ' alt='' title='' border=\"0\" /></a>";
                        litNewstMovies.Text += "<a href=\"Resever/"  + scheduler.SchID + "\"><img src='../../Content/Images/" + scheduler.Movie.Image + " ' alt='' title='' border=\"0\" /></a>";
                        litNewstMovies.Text += "<div class=\"caption\">";
                        litNewstMovies.Text += "<h3>" + scheduler.Movie.name + "</h3>";

                        litNewstMovies.Text += "<p>";

                        litNewstMovies.Text += "<a href=\"Resever.aspx?id=" + scheduler.Movie.MovieID + "\" class=\"btn btn-primary\">" + scheduler.Movie.Price + "&nbsp;" + "DKK" + "</a>" + "&nbsp;";

                        litNewstMovies.Text += "<a href=\"Resever.aspx?id=" + scheduler.Movie.MovieID + "\" class=\"btn btn-default\">" + "&nbsp;" + "Resever" + "</a>";

                        litNewstMovies.Text += "</p>";



                        litNewstMovies.Text += "</div>";

                        litNewstMovies.Text += "</div>";
                        litNewstMovies.Text += "</div>";

                    }


                }

                litNewstMovies.Text += "</div>";

                litNewstMovies.Text += "</div>";

            }

        }
    }
}