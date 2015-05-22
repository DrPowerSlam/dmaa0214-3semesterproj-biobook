using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ClientWebApp.CustomerServiceReference;
using ServerProject.DatabaseLayer;


namespace ClientWebApp
{
    public partial class Adduser : System.Web.UI.Page
    {
        //var client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");

        CustomerServiceClient client = new CustomerServiceClient("BasicHttpBinding_ICustomerService");
        protected void Page_Load(object sender, EventArgs e)
        {
         

            if(!IsPostBack)
            {
                
            }

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
                Customer objCustomer = new Customer();




                objCustomer.name +=  txtName.Text;
                objCustomer.phoneNumber +=  "+ 45" + txtPhone.Text; ;
                objCustomer.password += txtPassword.Text ;
                objCustomer.mail +=  txtMail.Text;

                client.MakeCustomer(objCustomer.name, objCustomer.phoneNumber, objCustomer.phoneNumber, objCustomer.mail);


          
                

      

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}