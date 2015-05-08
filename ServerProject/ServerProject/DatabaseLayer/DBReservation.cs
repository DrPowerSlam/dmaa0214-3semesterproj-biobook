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
        ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
        public IEnumerable getReservation()
        {
            
            DBCustomer dbCustomer = new DBCustomer();
            List<Customer> customers = dbCustomer.getAllCustomers().Cast<Customer>().ToList();
            List<Reservation> reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();

            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select res;

            return cusResJoin;
        }

        public void insertReservation(Reservation res)
        {
            //make it a reservation
           
            Reservation reservation = new Reservation();
            reservation = res;

            
            db.Reservations.InsertOnSubmit(reservation);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
