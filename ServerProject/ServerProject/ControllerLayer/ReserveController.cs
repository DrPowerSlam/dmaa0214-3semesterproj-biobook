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
        List<Reservation> listToReturn = new List<Reservation>();

        public IEnumerable getReservationsByCustomerID(int customerID)
        {
            foreach (Reservation r in dbRes.getReservation().Cast<Reservation>())
            {
                if(r.Customer.CusID == customerID)
                {
                    listToReturn.Add(r);
                }

            }

            return listToReturn;
        }

        public void findReservationByPhone(string phone)
        {

        }
        public void makeReservation(string row, string seat, int schedulerID, int customerID)
        {
            dbRes.makeReservation(row, seat, schedulerID, customerID);
        }

    }
}
