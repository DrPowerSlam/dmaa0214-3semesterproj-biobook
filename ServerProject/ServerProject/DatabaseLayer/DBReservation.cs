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
        private IEnumerable customerList;
        private IEnumerable reservationList;


     

        public void getReservation()
        {
            var db = new ConnectToDatabaseDataContext();
            DBCustomer dbCustomer = new DBCustomer();
            List<Customer> customers = null;
            List<Reservation> reservation = null;

            if (customers == null)
                customers = dbCustomer.getAllCustomers().Cast<Customer>().ToList();

            if (reservation == null)
                reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();


            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select new {cusID = cust.CusID, Name = cust.name, Phone = cust.phoneNumber, ResID = res.ResID, ResSchID = res.SchedulerID, ResRow = res.Row, ResSeat = res.Seat };

            foreach (var item in cusResJoin)
            {
                Console.WriteLine("Customer ID: " + item.cusID + "\n" + "Name: " + item.Name + "\n" + "Phone: " + item.Phone + "\n" + "Reservation ID: " + item.ResID + "\n" + "Scheduler ID: " + item.ResSchID + "\n" + "Row: " + item.ResRow + "\n" + "Seat: " + item.ResSeat + "\n");
            }
        }
    }
}
