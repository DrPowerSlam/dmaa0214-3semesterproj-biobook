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

        public IEnumerable getReservations()
        {
            return dbRes.getReservation();
        }

        public void findReservationByPhone(string phone)
        {

        }
        public void makeReservation(string row, string seat, int schedulerID, int customerID)
        {
            //Husk at den returner en controlInt for at se om programmet failet i at indsætte i databasen.
            dbRes.makeReservation(row, seat, schedulerID, customerID);
        }

    }
}
