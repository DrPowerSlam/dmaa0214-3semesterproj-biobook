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
        
        /// <summary>
        /// Gets a list of reservations by a customer ID
        /// </summary>
        /// <param name="customerID">The ID of the customer</param>
        /// <returns>Returns a list of reservations</returns>
        public List<Reservation> GetReservationsByCustomerID(int customerID)
        {
            List<Reservation> listToReturn = new List<Reservation>();
            foreach (Reservation r in dbRes.GetReservation().Cast<Reservation>())
            {
                if (r.Customer.CusID == customerID)
                {
                    listToReturn.Add(r);
                }

            }

            return listToReturn;
        }

        /// <summary>
        /// Find a list reservations by a customers phone number
        /// </summary>
        /// <param name="phone">The phone number of the customer</param>
        /// <returns>Returns a list of reservations</returns>
        public List<Reservation> FindReservationByPhone(string phone)
        {
            List<Reservation> listToReturn = new List<Reservation>();
            foreach (Reservation r in dbRes.GetReservation().Cast<Reservation>())
            {
                if (r.Customer.phoneNumber.Equals(phone))
                {
                    listToReturn.Add(r);
                }

            }

            return listToReturn;
        }

        //This needs to have both schedulerID customerId and row and seat.
        //e.g. row = "1,1,1" seat = "2,3,4"
        /// <summary>
        /// Creats a reservation, updating the database
        /// </summary>
        /// <param name="row">The rows of the seats in format "1,2,1,1"</param>
        /// <param name="seatArray">The indexes of the seats in format "1,1,2,3". It is possible to reserve 1 twice, if the rows are different</param>
        /// <param name="schedulerID">The scheduler ID where you want to make a reservation</param>
        /// <param name="customerID">The customer ID of the customer that wants to make a reservation</param>
        /// <returns>Returns a boolean that is true or false, depending on success</returns>
        public bool MakeReservation(string row, string seatArray, int schedulerID, int customerID)
        {
            
            bool isAvailable = true;
            
            //find seat by schedulerID and use row and seat to see if they are available.
            //lock here. After you have writtin to the database release the lock.
            DBSeat seatTable = new DBSeat();
            string[] rowArray = row.Split(',');
            //Console.WriteLine(rowArray[3]);
            //check if the row exist in database.
            for (int i = 0; i < rowArray.Length - 1; i++)
            {
                
                int rowIndex;
                Int32.TryParse(rowArray[i], out rowIndex);
                List<Seat> eachRowList = seatTable.GetSeatsBySchIDAndRow(schedulerID, rowIndex);
                //Console.WriteLine(eachRowList.First().Row);
                
                foreach(Seat eachRow in eachRowList)
                {
                    //Console.WriteLine(eachRow.Row);
                    //check if the seat is available by using the seatArray (which is the index in the seatlist)
                    string[] checkSeat = seatArray.Split(',');

                    string[] seatList = eachRow.ColumnArray.Split(',');

                    //check the index from checkSeat and see if that index in seatList is available
                    foreach (string check in checkSeat)
                    {
                        int index = 0;
                        Int32.TryParse(check, out index);
                        int seatPoint;
                        Int32.TryParse(seatList[index], out seatPoint);
                        if (seatPoint <= 0)
                        {
                            //The seat is not available, therefore you should not reserve it.
                            isAvailable = false;
                            return isAvailable;
                        }
                        index++;

                    }
                }
            }
                
            
            //Remember to update seat in the seat table also. Or else it will only be updated in the reserve table.
            //so call to the dbSeat and make an update there also.

            Reservation reservation = new Reservation();

            reservation.Seat = seatArray;
            reservation.Row = row;

            reservation.CustomerID = customerID;
            reservation.SchedulerID = schedulerID;
            int charArrayIndex = 0;
            string[] splitSeatArray = seatArray.Split(',');
            char[] charArray = new char[splitSeatArray.Length];
            while (charArrayIndex < charArray.Length)
            {
                charArray[charArrayIndex] = '0';
                charArrayIndex++;
            }
            seatTable.UpdateSeat(row, seatArray, charArray, schedulerID);

            //Husk at den returner en controlInt for at se om programmet failet i at indsætte i databasen.
            dbRes.insertReservation(reservation);
            return isAvailable;

        }

        /// <summary>
        /// Updates a reservation
        /// </summary>
        /// <param name="resID">The reservation ID you want to update</param>
        /// <param name="row">The rows of the seats you want to update in format "1,1,2,2"</param>
        /// <param name="seatArray">The seats you want to update, in format "1,2,2,3". See MakeReservation for more info</param>
        /// <param name="schedulerID">The scheduler ID of the reservation you want to update</param>
        /// <param name="customerID">The Customer ID, if the reservation needs to be assigned to a new customer</param>
        public void UpdateReservation(int resID, string row, string seatArray, int schedulerID, int customerID)
        {
            dbRes.UpdateReservation(resID, customerID, row, seatArray, schedulerID);
        }

        /// <summary>
        /// Get a reservation by customer phone number
        /// </summary>
        /// <param name="phone">The phone number of the customer</param>
        /// <returns>Returns a list of reservations</returns>
        public List<Reservation> GetResByCusPhone(string phone)
        {
            return dbRes.GetReservationByCusPhone(phone);
        }
    }
}
