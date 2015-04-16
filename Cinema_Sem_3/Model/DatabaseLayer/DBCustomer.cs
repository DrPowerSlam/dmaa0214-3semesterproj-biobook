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

            ServerProject.ModelLayer.Customer customer = (ServerProject.ModelLayer.Customer)db.Customers.Single(x => x.CusID == customerID);
            //db.Customers.Select(x => x).AsEnumerable().Where(x => x.CusID == customerID).Cast<ModelLayer.Customer>();


            return customer;
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
