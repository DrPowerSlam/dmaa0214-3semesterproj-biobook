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
using System.Web.Services;

namespace ClientWebApp
{
    public partial class Resever : System.Web.UI.Page
    {
        CustomerServiceClient client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");
        int schedulerID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            schedulerID = Convert.ToInt32(Page.RouteData.Values["SchID"]);

            if (!IsPostBack)
            {

                for (int j = 0; j < 10; j++)
                {
                    ddlTickets.Items.Add(new ListItem(j.ToString(), j.ToString()));
                }


            }

       

          //  ddlTickets_SelectedIndexChanged(sender, e);



            

            litMovieInfo.Text = schedulerID.ToString();


            Scheduler scheduler = client.GetSchedulerByID(schedulerID);



      




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

        protected void ddlTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

            litSeatList.Text = ddlTickets.SelectedItem.Text;

            //ddlTickets.SelectedItem.Value;
        }

        
      
            //int amount;
            //Int32.TryParse(ddlTickets.SelectedItem.Value, out amount);
            //List<int> bestSeats = client.GetBestSeats(amount, schedulerID);

            //if (bestSeats == null)
            //{
            //    litSeatList.Text += "nederen";
            //}
            //else
            //{
            //    litSeatList.Text += "Rækken er: " + bestSeats[1].ToString();
            //    litSeatList.Text += "Total point er :" + bestSeats[0].ToString();
            //    litSeatList.Text += "sæderne er: ";
            //    for (int x = 2; x < bestSeats.Count - 1; x++)
            //        litSeatList.Text += bestSeats[x].ToString() + ", ";

            //}
            
       
    }
}