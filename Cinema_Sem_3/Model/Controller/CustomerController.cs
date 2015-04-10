using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Database;
using System.Collections;

namespace Model.Controller
{
    public class CustomerController
    {
        DBCustomer dbCus = new DBCustomer();

        public ArrayList getAllCustomers()
        {
            return dbCus.getAllCustomers();
        }

        public Customer findCustomerByID(string ID)
        {
            return dbCus.selectWhereID(ID);
        }

        public ArrayList findCustomersByName(string name)
        {
            return dbCus.selectWhereName(name);
        }
    }
}
