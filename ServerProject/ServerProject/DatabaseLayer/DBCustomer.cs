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

        public Customer selectWhereID(int customerID)
        {
            var db = new ConnectToDatabaseDataContext();

            Customer customer = (Customer)db.Customers.Single(x => x.CusID == customerID);
            //db.Customers.Select(x => x).AsEnumerable().Where(x => x.CusID == customerID).Cast<ModelLayer.Customer>();


            return customer;
        }

        public IEnumerable selectWhereName(string name)
        {

            var db = new ConnectToDatabaseDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable().Where(x => x.name.Equals(name));

            return customer;
        }

        //TO-DO:
        //Ændre denne funktion så den primært fungere i controlleren
        public IEnumerable getAllCustomers()
        {
            var db = new ConnectToDatabaseDataContext();

            var customer = db.Customers.Select(x => x).AsEnumerable();

            return customer;
        }

        public int insertCustomer(string name)
        {
            int controlInt = -1;
            var db = new ConnectToDatabaseDataContext();

            Customer customer = new Customer();
            customer.name = name;

            db.Customers.InsertOnSubmit(customer);

            try
            {
                db.SubmitChanges();
                controlInt = 1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return controlInt;
        }
    }
      
}
