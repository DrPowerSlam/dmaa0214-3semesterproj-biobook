using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServerProject.DatabaseLayer;
using ServerProject.ControllerLayer;
using ClientWebApp.CustomerServiceReference;

namespace ClientWebApp
{
    public partial class Resever : System.Web.UI.Page
    {     

        protected void Page_Load(object sender, EventArgs e)
        {

            var client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");                      

            string str = Page.RouteData.Values["name"].ToString();
            
            //Movie movie = client.FindMovieByName(str);

            //Scheduler scheduler = client.GetSchedulerByMovieID(movie.MovieID);
            //litSeatList.Text += 
            //litMovieInfo.Text += movie.MovieID;

            litMovieInfo.Text += "<div class=\"col-md-3\">";

            litMovieInfo.Text += "<img src=\"../../Content/Images/" + movie.Image + "\" + class=\"MovieImg\" />";

            litMovieInfo.Text += "</div>";

            litMovieInfo.Text += "<div class=\"col-md-3\">";

            litMovieInfo.Text += movie.name;

            litMovieInfo.Text += "</div>";


            
            //foreach(1
            //litSeatList.Text +=



        }
    }
}