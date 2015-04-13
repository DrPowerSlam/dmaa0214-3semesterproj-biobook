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

        public IEnumerable getAllCustomers()
        {
            return dbCus.getAllCustomers();
        }

        public ServerProject.ModelLayer.Customer findCustomerByID(int ID)
        {
            return dbCus.selectWhereID(ID);
        }

        public ArrayList findCustomersByName(string name)
        {
            ArrayList customerList = new ArrayList();
            foreach (Customer c in dbCus.selectWhereName(name))
            {
                if (c.name == name)
                {
                    ServerProject.ModelLayer.Customer customerModel = new ServerProject.ModelLayer.Customer();
                    customerModel.CusID = c.CusID;
                    customerModel.Name = c.name;
                    customerList.Add(customerModel);
                }
            }
            return customerList;
        }
    }
}
