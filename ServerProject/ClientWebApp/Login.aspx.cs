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


namespace ClientWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (ValidateUser(txtMail.Text, txtPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtMail.Text, false);
                Response.Redirect("UI/Startpage.aspx");
            }

            else
            {
                Response.Redirect("Default.aspx", true);
            }
             
        }

        private bool ValidateUser(string userName, string passWord)
        {
            Page.Validate();
            if (!Page.IsValid)
            {
                return false;
            }

            try
            {
                // Get user from database
                var db = new ConnectToDatabaseDataContext();
                Customer user = (from m in db.Customers
                               where m.mail.ToLower() == userName.ToLower() &&
                                     m.password == passWord
                               select m).SingleOrDefault();

                if (user != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // System.Diagnostics.Trace.WriteLine("[ValidateUser] Exception " + ex.Message);
            }

            return false;
        }

    }
}