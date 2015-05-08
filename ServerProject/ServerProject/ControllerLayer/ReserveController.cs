using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ServerProject.DatabaseLayer;

namespace ServerProject.ControllerLayer
{
    public class ReserveController
    {
        DBReservation dbRes = new DBReservation();
        

        public IEnumerable getReservationsByCustomerID(int customerID)
        {
            List<Reservation> listToReturn = new List<Reservation>();
            foreach (Reservation r in dbRes.getReservation().Cast<Reservation>())
            {
                if (r.Customer.CusID == customerID)
                {
                    listToReturn.Add(r);
                }

            }

            return listToReturn;
        }

        public List<Reservation> findReservationByPhone(string phone)
        {
            List<Reservation> listToReturn = new List<Reservation>();
            foreach (Reservation r in dbRes.getReservation().Cast<Reservation>())
            {
                if (r.Customer.phoneNumber.Equals(phone))
                {
                    listToReturn.Add(r);
                }

            }

            return listToReturn;
        }
        public void makeReservation(string row, string seat, int schedulerID)
        {
            //Husk at den returner en controlInt for at se om programmet failet i at indsætte i databasen.
            //dbRes.makeReservation(row, seat, schedulerID, customerID);
        }
    }
}
