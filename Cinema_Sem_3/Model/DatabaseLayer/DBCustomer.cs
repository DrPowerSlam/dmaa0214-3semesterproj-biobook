using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ServerProject.ModelLayer;


namespace ServerProject.DatabaseLayer
{
    class DBCustomer
    {
        public DBCustomer()
        { 
        }

        public ServerProject.ModelLayer.Customer selectWhereID(int customerID)
        {
            var db = new ConnectToDBDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable().Where(x => x.CusID == customerID);

            ServerProject.ModelLayer.Customer customerModel = new ServerProject.ModelLayer.Customer();

            customerModel.ID = customer.First().CusID;
            customerModel.Name = customer.First().name;

            return customerModel;
        }

        public ArrayList selectWhereName(string name)
        {
            ArrayList customerList = new ArrayList();

            var db = new ConnectToDBDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable();

            foreach(Customer c in customer)
            {
                if(c.name == name)
                {
                    ServerProject.ModelLayer.Customer customerModel = new ServerProject.ModelLayer.Customer();
                    customerModel.ID = c.CusID;
                    customerModel.Name = c.name;
                    customerList.Add(customerModel);
                }
            }

            return customerList;
        }

        //TO-DO:
        //Ændre denne funktion så den primært fungere i controlleren
        public ArrayList getAllCustomers()
        {
            ArrayList customerList = new ArrayList();

            var db = new ConnectToDBDataContext();
            int customerID = 1;

            while (customerID <= db.Customers.AsEnumerable().Last().CusID)
            {
                var customer = db.Customers.Select(x => x).AsEnumerable().Where(x => x.CusID == customerID).Where(x => !x.name.Equals(null));
                ServerProject.ModelLayer.Customer customerModel = new ServerProject.ModelLayer.Customer();
                customerModel.ID = customer.First().CusID;
                customerModel.Name = customer.First().name;
                customerList.Add(customerModel);
                customerID++;
            }

            return customerList;
        }
    }
      
}
