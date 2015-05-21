using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.Threading;

namespace ServerProject.DatabaseLayer
{
    class DBReservation
    {
        private object lockToken = new object();        

        public IEnumerable GetReservation()
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            DBCustomer dbCustomer = new DBCustomer();
            List<Customer> customers = dbCustomer.GetAllCustomers().Cast<Customer>().ToList();
            List<Reservation> reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();

            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select res;

            return cusResJoin;
        }

        public void UpdateReservation(int customerID, string row, string seat, int schID)
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            db.Connection.Open();
            db.Transaction = db.Connection.BeginTransaction(IsolationLevel.RepeatableRead);
            Reservation reservation = db.Reservations.First(r => r.ResID == 4);

            reservation.CustomerID = customerID;
            reservation.Row = row;
            reservation.Seat = seat;
            reservation.SchedulerID = schID;
                
                try
                {
                    db.SubmitChanges();
                    db.Transaction.Commit();
                    db.Transaction.Dispose();
                    //transation.Complete();
                    db.Connection.Close();

                }
                catch (Exception e)
                {
                    db.Transaction.Rollback();
                    Console.WriteLine(e);
                }
        }
        public void insertReservation(Reservation res)
        {
            //make it a reservation
            Reservation reservation = new Reservation();
            reservation = res;

            //lock it so only one at a time can work with it?
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            db.Reservations.InsertOnSubmit(reservation);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                db.Transaction.Rollback();
                Console.WriteLine(e);
            }

        }
    }
}
