using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ServerProject.DatabaseLayer;
using System.Collections;

namespace ServerProject.ControllerLayer
{
    public class CustomerController
    {

        DBCustomer dbCus = new DBCustomer();

        /// <summary>
        /// Gets all the customers from the databaselayer
        /// </summary>
        /// <returns>Returns the list of customers</returns>
        public IEnumerable GetAllCustomers()
        {
            return dbCus.GetAllCustomers();
        }

        /// <summary>
        /// Finds a customer by it's ID
        /// </summary>
        /// <param name="ID">The ID to search for</param>
        /// <returns>The customer, if any is found</returns>
        public Customer GetCustomerByID(int ID)
        {
            return dbCus.GetCustomerByID(ID);
        }

        public Customer CustomerLogin(string userMail, string passWord)
        {
         
            return dbCus.CustomerLogin(userMail, passWord);
        }

        public Customer FindCustomerByEmail(string email)
        {
            return dbCus.GetCustomerByEmail(email);
        }


        /// <summary>
        /// Finds all the customers with a given name
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <returns>Returns a list of customers</returns>
        public IEnumerable  FindCustomerByName(string name)
        {
            return dbCus.GetCustomerByName(name);
        }

        /// <summary>
        /// Inserts a customer to the database
        /// </summary>
        /// <param name="name">The name of the customer (ID is auto-generated)</param>
        public void InsertCustomer(string name, string phoneNumber, string password, string mail)
        {
            //make some checks here.
            dbCus.InsertCustomer(name, phoneNumber, password, mail);
        }

        /// <summary>
        /// Deletes a customer with a given ID
        /// </summary>
        /// <param name="cusID">The ID of the customer to delete</param>
        public void DeleteCustomer(int cusID)
        {
            dbCus.DeleteCustomer(cusID);
        }

        public Customer getByPhone(string phone)
        {
            return dbCus.GetByPhone(phone);
        }

        public void UpdateCustomer(int customerID, string name, string email, string phone, string password)
        {
            dbCus.UpdateCustomer(customerID, name, email, phone, password);
        }
    }
}
