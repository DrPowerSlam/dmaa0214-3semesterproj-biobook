using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ClientWebApp.CustomerServiceReference;

using ServerProject.DatabaseLayer;
using ServerProject.ControllerLayer;
using System.Web.Security;
using System.Web.Services.Description;
using System.Data;


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
                Customer customer = clien

                Session["userID"] = 
               // Session["userID"] = txtMail.Text;
                FormsAuthentication.RedirectFromLoginPage(txtMail.Text, false);


            }

            


        }

        private bool ValidateUser(string userName, string passWord)
        {
            

            var client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");
       
            Customer customer = new Customer();

            customer.mail = userName;
            customer.password = passWord;

            
            
          //  Session["cusID"] = customer.CusID;
            

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

     

    }

}