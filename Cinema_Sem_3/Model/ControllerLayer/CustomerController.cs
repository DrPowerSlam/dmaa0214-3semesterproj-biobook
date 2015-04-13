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

        public ArrayList getAllCustomers()
        {
            return dbCus.getAllCustomers();
        }

        public ServerProject.ModelLayer.Customer findCustomerByID(int ID)
        {
            return dbCus.selectWhereID(ID);
        }

        public ArrayList findCustomersByName(string name)
        {
            return dbCus.selectWhereName(name);
        }
    }
}
