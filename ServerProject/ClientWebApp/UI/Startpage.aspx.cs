using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClientWebApp.CustomerServiceReference;
using ServerProject.DatabaseLayer;
using System.Web.Security;
using System.Web.Services.Description;


namespace ClientWebApp.UI
{
    public partial class Startpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                //FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}