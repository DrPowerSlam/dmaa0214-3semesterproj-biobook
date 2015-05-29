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
using System.Data;
using System.Security.Cryptography;


namespace ClientWebApp.UI
{
    public partial class Startpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");
            Customer cus = new Customer();

            bool val1 = (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            //var db = new ConnectToDatabaseDataContext();
            //var mail = HttpContext.Current.User.Identity.Name;
            //int userID = db.Customers.Single(x => x.mail.Equals (mail) ).CusID;

              //int _ID = Convert.ToInt32(Request.QueryString["id"]);

              var tst = client.GetCustomerByID(Convert.ToInt32(Session["UserID"]));

              string test = tst.password += tst.name;

         
     

            

            if (val1 == true)
            {
                reg.Visible = false;
                log.Visible = false;
                logout.Visible = true;

                litUser.Text = test;

            }

            if (val1 == false)
            {
                logout.Visible = false;
                Response.Redirect("../Login.aspx");
            }


          //  if (HttpContext.Current.User == null)
          //  {


          //      //FormsAuthentication.SignOut();
          //      litUser.Text = "DU er ikke logget ind";
          //  }
       

          //  //System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated
          //if (HttpContext.Current.User != null && HttpContext.Current.User.Identity.IsAuthenticated)
          //{

           

          //    litUser.Text = "Hej";
          //}
        }

       public void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("../Login.aspx");
        }

      
          
            
    }
}