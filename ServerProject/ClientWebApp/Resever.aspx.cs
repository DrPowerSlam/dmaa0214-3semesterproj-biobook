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
    public partial class Resever : System.Web.UI.Page
    {
        ServerProject.ControllerLayer.MovieController movCtr = new MovieController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                litMovieInfo.Text += "hehe";
            }
           
        }
    }
}