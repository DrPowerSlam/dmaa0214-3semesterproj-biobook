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
        public IEnumerable getReservation(int customerID)
        {
            var db = new ConnectToDatabaseDataContext();
            DBCustomer dbCustomer = new DBCustomer();
            List<Customer> customers = dbCustomer.getAllCustomers().Cast<Customer>().ToList();
            List<Reservation> reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();

            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals customerID
                             select new {cusID = cust.CusID, Name = cust.name, Phone = cust.phoneNumber, ResID = res.ResID, ResSchID = res.SchedulerID, ResRow = res.Row, ResSeat = res.Seat };

            foreach (var c in cusResJoin)
            {
                Console.WriteLine(c.cusID + " " + c.Name + " " + c.ResSchID + " " + c.ResRow + " " + c.ResSeat + " " + c.ResID);
            }

            return cusResJoin;
        }
    }
}
