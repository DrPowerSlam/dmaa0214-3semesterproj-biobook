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


            int i = Convert.ToInt32(Page.RouteData.Values["SchID"]);


            litMovieInfo.Text += i;


            Scheduler scheduler = client.GetSchedulerByID(i);

            /*
            for (int j = 0; j < 10; j++)
            {
                ddlTickets.Items.Add(new ListItem(j.ToString(), j.ToString()));
            }

            int amount;
            Int32.TryParse(ddlTickets.SelectedItem.Value, out amount);
            */

            List<int> bestSeats = client.GetBestSeats(1, i);

            foreach(int j in bestSeats)
            {
                litSeatList.Text += j.ToString();
            }


            //Scheduler scheduler = client.GetSchedulerByMovieID(movie.MovieID);
            //litSeatList.Text += 
            //litMovieInfo.Text += movie.MovieID;

            litMovieInfo.Text += "<div class=\"col-md-3\">";

        //    litMovieInfo.Text += "<img src=\"../../Content/Images/" + movie.Image + "\" + class=\"MovieImg\" />";

            litMovieInfo.Text += "</div>";

            litMovieInfo.Text += "<div class=\"col-md-3\">";

          //  litMovieInfo.Text += movie.name;

            litMovieInfo.Text += "</div>";


            
            //foreach(1
            //litSeatList.Text +=



        }
    }
}