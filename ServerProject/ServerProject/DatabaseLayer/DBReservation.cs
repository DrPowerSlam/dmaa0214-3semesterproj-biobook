using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
<<<<<<< HEAD
=======
using System.Threading;
>>>>>>> parent of 8afe8ad... Se tidligere kommentar.

namespace ServerProject.DatabaseLayer
{
    class DBReservation
    {
        private object lockToken = new object();
        ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
        public IEnumerable getReservation()
        {
            
            DBCustomer dbCustomer = new DBCustomer();
            List<Customer> customers = dbCustomer.GetAllCustomers().Cast<Customer>().ToList();
            List<Reservation> reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();

            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select res;

            return cusResJoin;
        }

<<<<<<< HEAD
=======
        public void UpdateReservation(Reservation res, int sleepTime)
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            db.Connection.Open();
            db.Transaction = db.Connection.BeginTransaction(IsolationLevel.RepeatableRead);
            Reservation reservation = db.Reservations.First(r => r.CustomerID == res.CustomerID);
            reservation.Row = res.Row;
            reservation.SchedulerID = res.SchedulerID;
            reservation.Seat = res.Seat;
            reservation.CustomerID = reservation.CustomerID;
            Console.WriteLine("Thread is now sleeping");
            try
            {
                Thread.Sleep(sleepTime);
                Console.WriteLine("Thread is now not sleeping");
                db.SubmitChanges();
                db.Connection.Close();

            }
            catch (Exception e)
            {
                db.Transaction.Rollback();
                Console.WriteLine(e);
            }

        }


>>>>>>> parent of 8afe8ad... Se tidligere kommentar.
        public void insertReservation(Reservation res)
        {
            //make it a reservation
           
            Reservation reservation = new Reservation();
            reservation = res;

            //lock it so only one at a time can work with it?

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
