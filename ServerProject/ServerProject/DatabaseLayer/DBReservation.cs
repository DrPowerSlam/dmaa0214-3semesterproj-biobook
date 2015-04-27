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
        private List<Customer> customerList;
        private List<Reservation> reservationList;


     

        public void getReservation()
        {
            List<Customer> customers = GetCustomerList();
            List<Reservation> reservation = GetReservationList();


            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select new {cusID = cust.CusID, Name = cust.name, Phone = cust.phoneNumber, ResID = res.ResID, ResSchID = res.SchedulerID, ResRow = res.Row, ResSeat = res.Seat };

            foreach (var item in cusResJoin)
            {
                Console.WriteLine("Customer ID: " + item.cusID + "\n" + "Name: " + item.Name + "\n" + "Phone: " + item.Phone + "\n" + "Reservation ID: " + item.ResID + "\n" + "Scheduler ID: " + item.ResSchID + "\n" + "Row: " + item.ResRow + "\n" + "Seat: " + item.ResSeat + "\n");
            }
      

        }

        public List<Customer> GetCustomerList()
        {
            if (customerList == null)
                createCustomer();

            return customerList;
        }

        public List<Reservation> GetReservationList()
        {
            if (reservationList == null)
                createReservation();

            return reservationList;
        }


        public void  createCustomer()
        {
            
            var db = new ConnectToDatabaseDataContext();

            customerList = db.Customers.Select(x => x).AsEnumerable().ToList();

          

        }

        public void createReservation()
        {
            var db = new ConnectToDatabaseDataContext();

            reservationList = db.Reservations.Select(x => x).AsEnumerable().ToList();

        

        }

        //public IEnumerable getAllCustomers()
        //{
        //    var db = new ConnectToDatabaseDataContext();

        //    var customer = db.Customers.Select(x => x).AsEnumerable();

        //    return customer;
        //}




    }
}
