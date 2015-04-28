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

        public IEnumerable getReservations(int customerID)
        {
            return dbRes.getReservation(customerID);
        }

        public void findReservationByPhone(string phone)
        {

        }
        public void makeReservation(string row, string seat, int schedulerID)
        {
            //reserveSeat(string row, string seat, int schedulerID);

        }

    }
}
