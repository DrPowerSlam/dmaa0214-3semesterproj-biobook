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
        public IEnumerable getAllCustomers()
        {
            return dbCus.getAllCustomers();
        }

        /// <summary>
        /// Finds a customer by it's ID
        /// </summary>
        /// <param name="ID">The ID to search for</param>
        /// <returns>The customer, if any is found</returns>
        public Customer findCustomerByID(int ID)
        {
            return dbCus.selectWhereID(ID);
        }

        /// <summary>
        /// Finds all the customers with a given name
        /// </summary>
        /// <param name="name">The name to search for</param>
        /// <returns>Returns a list of customers</returns>
        public IEnumerable findCustomersByName(string name)
        {
            return dbCus.selectWhereName(name);
        }

        /// <summary>
        /// Inserts a customer to the database
        /// </summary>
        /// <param name="name">The name of the customer (ID is auto-generated)</param>
        public void insertCustomer(string name)
        {
            dbCus.insertCustomer(name);
        }

        /// <summary>
        /// Deletes a customer with a given ID
        /// </summary>
        /// <param name="cusID">The ID of the customer to delete</param>
        public void deleteCustomer(int cusID)
        {
            dbCus.deleteCustomer(dbCus.selectWhereID(cusID));
        }
    }
}
