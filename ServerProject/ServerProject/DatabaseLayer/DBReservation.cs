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
        public ArrayList getReservation(int customerID)
        {
            var db = new ConnectToDatabaseDataContext();
            DBCustomer dbCustomer = new DBCustomer();
            ArrayList list = new ArrayList();
            List<Customer> customers = dbCustomer.getAllCustomers().Cast<Customer>().ToList();
            List<Reservation> reservation = db.Reservations.Select(x => x).AsEnumerable().ToList();

            var cusResJoin = from res in reservation
                             join cust in customers on res.CustomerID equals cust.CusID
                             select new {cusID = cust.CusID, Name = cust.name, Phone = cust.phoneNumber, ResID = res.ResID, ResSchID = res.SchedulerID, ResRow = res.Row, ResSeat = res.Seat };

            for (int i = 0; i < cusResJoin.Count(); i++)
            {
                if(cusResJoin.ElementAt(i).cusID == customerID)
                {
                    ModelLayer.Customer customer = new ModelLayer.Customer();
                    customer.name = cusResJoin.ElementAt(i).Name;
                    customer.phoneNumber = cusResJoin.ElementAt(i).Phone;
                    ModelLayer.Reservation newReservation = new ModelLayer.Reservation();
                    newReservation.Customer = customer;
                    newReservation.ResID = cusResJoin.ElementAt(i).ResID;
                    newReservation.RowArray = int.Parse(cusResJoin.ElementAt(i).ResRow);
                    newReservation.SeatArray = int.Parse(cusResJoin.ElementAt(i).ResSeat);
                    newReservation.SchedulerID = (int)cusResJoin.ElementAt(i).ResSchID;
                    list.Add(newReservation);
                }
            }

            return list;
        }
    }
}
