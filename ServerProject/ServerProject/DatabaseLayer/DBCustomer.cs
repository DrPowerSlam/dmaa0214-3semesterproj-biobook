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


      //  public Customer CustomerLogin(string userMail, string passWord)

        /// <summary>
        /// Find a customer by e-mail
        /// </summary>
        /// <param name="email">The e-mail of the customer</param>
        /// <returns>The customer object</returns>
        public Customer GetCustomerByEmail(string email)
        {

            var db = new ConnectToDatabaseDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable().Single(x => x.mail == email);

            return customer;
        }


        /// <summary>
        /// A login method for a user
        /// </summary>
        /// <param name="userMail">The user e-mail</param>
        /// <param name="passWord">The user password</param>
        /// <returns>Returns true if the user logged in successfully, false if not</returns>
        public bool CustomerLogin(string userMail, string passWord)

        {
            try
            {
                var db = new ConnectToDatabaseDataContext();

                Customer user = (from c in db.Customers where c.mail.ToLower() == userMail.ToLower() && c.password == passWord   select  c).SingleOrDefault();

                if (user.CusID > 0)
                {
                 
                    return user;
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine("[ValidateUser] Exception " + ex.Message);
            }

            return null;
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

        /// <summary>
        /// Update a customer
        /// </summary>
        /// <param name="customerID">The ID of the customer you want to edit</param>
        /// <param name="name">Name of the customer</param>
        /// <param name="email">Email of the customer</param>
        /// <param name="phone">Phone number of the customer</param>
        /// <param name="password">The new password for the customer</param>
        public void UpdateCustomer(int customerID, string name, string email, string phone, string password)
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();

            db.Connection.Open();
            db.Transaction = db.Connection.BeginTransaction(IsolationLevel.RepeatableRead);
            Customer customer = GetCustomerByID(customerID);

            customer.mail = email;
            customer.name = name;
            customer.phoneNumber = phone;
            customer.password = password;

            try
            {
                db.SubmitChanges();
                db.Transaction.Commit();
                db.Transaction.Dispose();
                db.Connection.Close();
            }
            catch (Exception e)
            {
                db.Transaction.Rollback();
                Console.WriteLine(e.Message);
            }
        }
    }

}
