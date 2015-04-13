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

        public IEnumerable selectWhereName(string name)
        {

            var db = new ConnectToDBDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable().Where(x => x.name.Equals(name));

            customer.First();

            return customer;
        }

        //TO-DO:
        //Ændre denne funktion så den primært fungere i controlleren
        public IEnumerable getAllCustomers()
        {
            var db = new ConnectToDBDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable();

            return customer;
        }
    }
      
}
