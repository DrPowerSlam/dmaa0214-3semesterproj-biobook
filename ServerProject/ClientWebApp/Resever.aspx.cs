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
            
            List<Movie> movies = client.FindMovieByName(str)

    

            litMovieInfo.Text += "<div class=\"col-md-3\">";

            litMovieInfo.Text += "<img src=\"../../Content/Images/" + movCtr.FindMovieByName(str).Image + "\" + class=\"MovieImg\" />";

            litMovieInfo.Text += "</div>";

            litMovieInfo.Text += "<div class=\"col-md-3\">";

            litMovieInfo.Text += movCtr.FindMovieByName(str).name;

            litMovieInfo.Text += "</div>";


            
            foreach(
            litSeatList.Text +=



        }
    }
}