using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ServerProject.DatabaseLayer
{
    class DBCustomer
    {
        public DBCustomer()
        {

        }
        /// <summary>
        /// Finds a customer by the customer ID
        /// </summary>
        /// <param name="customerID">The customer ID you want to search for</param>
        /// <returns>The customer, if it's found</returns>
        public Customer GetCustomerByID(int customerID)
        {
            var db = new ConnectToDatabaseDataContext();

            Customer customer = db.Customers.Single(x => x.CusID == customerID);

            return customer;
        }

        /// <summary>
        /// Selects the customer with the given phonenumber
        /// </summary>
        /// <param name="phone">The phonenumber which to search for</param>
        /// <returns>returns the customer with the phonernumber, if one exists</returns>
        public Customer GetByPhone(string phone)
        {
            var db = new ConnectToDatabaseDataContext();
            Customer customer = db.Customers.Single(x=> x.phoneNumber.Equals(phone));
            return customer;
        }
        /// <summary>
        /// Selects all customers with a given name
        /// </summary>
        /// <param name="name">The name which to search for</param>
        /// <returns>Returns a list of all customers with the name</returns>
        public IEnumerable GetCustomerByName(string name)
        {

            var db = new ConnectToDatabaseDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable().Where(x => x.name.Equals(name));

            return customer;
        }


        public Customer GetCustomerByEmail(string email)
        {

            var db = new ConnectToDatabaseDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable().Single(x => x.mail == email);

            return customer;
        }

        public bool CustomerLogin(string userMail, string passWord)
        {
            try
            {
                var db = new ConnectToDatabaseDataContext();

                Customer user = (from m in db.Customers
                                 where m.mail.ToLower() == userMail.ToLower() &&
                                     m.password == passWord
                                 select m).SingleOrDefault();

                if (user != null)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("[ValidateUser] Exception " + ex.Message);
            }

            return false;

        }

        /// <summary>
        /// Creates a list with all customers
        /// </summary>
        /// <returns>The list of customers</returns>
        public IEnumerable GetAllCustomers()
        {
            var db = new ConnectToDatabaseDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable();

            return customer;
        }

        /// <summary>
        /// Inserts a customer into the database
        /// </summary>
        /// <param name="name">The name of the customer (ID is auto-generated in the database)</param>
        /// <returns>Returns a control integer. 1 for success, -1 for failure</returns>
        public int InsertCustomer(string name, string phoneNumber, string password, string mail)
        {
            int controlInt = -1;
            var db = new ConnectToDatabaseDataContext();

            Customer customer = new Customer();
            customer.name = name;
            customer.phoneNumber = phoneNumber;
            customer.password = password;
            customer.mail = mail;

            db.Customers.InsertOnSubmit(customer);

            try
            {
                db.SubmitChanges();
                controlInt = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }
            return controlInt;
        }

        /// <summary>
        /// Deletes a customer
        /// </summary>
        /// <param name="customer">The customer object from the database to delete</param>
        /// <returns>Returns a control integer. 1 for success, -1 for failure</returns>
        public int DeleteCustomer(Customer customer)
        {
            int controlInt = -1;
            var db = new ConnectToDatabaseDataContext();

            Customer customerToDelete = new Customer();
            customerToDelete.name = customer.name;
            customerToDelete.CusID = customer.CusID;

            db.Customers.Attach(customerToDelete);
            db.Customers.DeleteOnSubmit(customerToDelete);

            try
            {
                db.SubmitChanges();
                controlInt = 1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return controlInt;
        }
    }

}
