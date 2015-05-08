﻿using System;
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
                if (r.Customer.CusID == customerID)
                {
                    listToReturn.Add(r);
                }

            }

            return listToReturn;
        }

        public void findReservationByPhone(string phone)
        {

        }

        //This needs to have both schedulerID customerId and row and seat.
        //ex. row = "1,1,1" seat = "2,3,4"
        public void makeReservation(string row, string seat, int schedulerID, int customerID)
        {
            Reservation reservation = new Reservation();

            reservation.Seat = seat;
            reservation.Row = row;

            reservation.CustomerID = customerID;
            reservation.SchedulerID = schedulerID;

            //Husk at den returner en controlInt for at se om programmet failet i at indsætte i databasen.
            dbRes.insertReservation(reservation);

        }
    }
}
