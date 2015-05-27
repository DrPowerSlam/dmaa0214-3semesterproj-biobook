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
            /*if (ValidateUser(txtMail.Text, txtPassword.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(txtMail.Text, false);
                Response.Redirect("UI/Startpage.aspx");
            }

            else
            {
                Response.Redirect("Default.aspx", true);
            }*/
               


        }

        private bool ValidateUser(string userName, string passWord)
        {

            var client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");
       
            Customer customer = new Customer();

            customer.mail = userName;
            customer.password = passWord;

            Page.Validate();
            
            if (!Page.IsValid)
            {
                return false;
            }

            try
            {
                

                if (client != null)
                {
                    if (client.CustomerLogin(customer.mail, customer.password))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("[ValidateUser] Exception " + ex.Message);
            }

            return false;
        }

        protected void loginWebsite_LoggingIn(object sender, LoginCancelEventArgs e)
        {
            //Check if there are texts in the fields etc. Right now there is none.
            loginWebsite.InstructionText = "";
        }

        protected void loginWebsite_Authenticate(object sender, AuthenticateEventArgs e)
        {

            if (ValidateUser(loginWebsite.UserName, loginWebsite.Password))
            {
                //Membership.CreateUser(loginWebsite.UserName, loginWebsite.Password);
                e.Authenticated = true;
                //Response.Redirect(FormsAuthentication.GetRedirectUrl(loginWebsite.UserName, false));
                loginWebsite.InstructionText = "Login successful";
            }

            else
            {
                e.Authenticated = false;
                loginWebsite.InstructionText = "Login Failed Redirecting";
                Response.Redirect("Default.aspx", true);
            }
        }

        protected void loginWebsite_LoggedIn(object sender, EventArgs e)
        {
            //When the user has logged in.
            FormsAuthentication.RedirectFromLoginPage(loginWebsite.UserName, loginWebsite.RememberMeSet);
            //Response.Redirect("UI/Startpage.aspx");
        }


    }

}