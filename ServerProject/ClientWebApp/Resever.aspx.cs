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
        static int[] bestSeats;

        protected void Page_Load(object sender, EventArgs e)
        {

            schedulerID = Convert.ToInt32(Page.RouteData.Values["SchID"]);

            if (!IsPostBack)
            {

                for (int j = 0; j < 10; j++)
                {
                    ddlTickets.Items.Add(new ListItem(j.ToString(), j.ToString()));
                }
                if ((System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    //the user is logged in therefore just show the reserver button
                    btnConfirm.Visible = true;
                    litLoggedOn.Visible = false;

                }
                //if the user is not logged on do something?


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
            int amount;
            Int32.TryParse(ddlTickets.SelectedItem.Value, out amount);
            bestSeats = client.GetBestSeats(amount, schedulerID);

            if (bestSeats == null)
            {
                litSeatList.Text = "Der er desværre ingen ledige pladser til de antal personer";
            }
            else
            {
                litSeatList.Text = "Rækken er: " + bestSeats[1].ToString() + " Total point er : " + bestSeats[0].ToString();
                litSeatList.Text += " Sæderne er: ";
                for (int x = 2; x < bestSeats.Length; x++)
                    litSeatList.Text += (bestSeats[x].ToString() + ", ");
                litSeatList.Text = litSeatList.Text.Remove(litSeatList.Text.Length - 2);
            }

            
            int[][] array = client.GetAllAvailableSeats(schedulerID);
            string copier = "<br>Row &nbsp;&nbsp;&nbsp;&nbsp; Seats<br>";
            for (int x = 0; x < array.Length; x++)
            {
                copier += x + 1 + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + array[x][0];
                for (int y = 1; y < array[x].Length; y++)
                {
                    copier += "-" + array[x][y];
                }
                copier += "<br>";
            }

            litMovieInfo.Text += copier;
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            //If the user is logged in then get his customerID
            int customerID = Convert.ToInt32(Session["UserID"]);
            string seats = "";
            for (int x = 2; x < bestSeats.Length; x++)
                seats += bestSeats[x].ToString() + ", ";
            seats = seats.Remove(seats.Length - 2);
            
            client.MakeReservation(bestSeats[1].ToString(), seats, schedulerID, customerID);
            litMovieInfo.Text = "Du har nu reserveret denne film";
            
        }
    }
}