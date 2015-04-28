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
    class DBReservation
    {
        public IEnumerable getReservation()
        {
            var db = new ConnectToDatabaseDataContext();
            DBCustomer dbCustomer = new DBCustomer();
            List<Customer> customers = dbCustomer.getAllCustomers().Cast<Customer>().ToList();
            List<Reservation> reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();

            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select res;

            return cusResJoin;
        }

        public void makeReservation(string row, string seat, int schedulerID, int customerID)
        {
            //insert a reservation into the databse:
        }
    }
}
