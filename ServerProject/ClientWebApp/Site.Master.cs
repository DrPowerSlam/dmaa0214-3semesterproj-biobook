using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServerProject.DatabaseLayer;
using ServerProject.ControllerLayer;

namespace ClientWebApp
{
    public partial class Site : System.Web.UI.MasterPage
    {
        ServerProject.ControllerLayer.MovieController movCtr = new MovieController();
   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (Movie movie in movCtr.GetAllMovies())
                {
                    litTest.Text += "<br/>" + movie.name;

                }
            }

      

            
            //foreach (Movie movie in movCtr.GetAllMovies())
            //{
            //    Console.WriteLine(movie.MovieID + ": " + movie.name + ". Playtime: " + movie.Playtime + "\n");
            //}




        }
    }
}