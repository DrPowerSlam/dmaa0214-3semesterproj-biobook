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

        //This needs to have both schedulerID customerId and row and seat.
        //ex. row = "1,1,1" seat = "2,3,4"
        public bool makeReservation(string row, string seatArray, int schedulerID, int customerID)
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
                        int index;
                        Int32.TryParse(check, out index);
                        int seatPoint;
                        Int32.TryParse(seatList[index-1], out seatPoint);
                        if (seatPoint < 0)
                        {
                            //The seat is not available, therefore you should not reserve it.
                            isAvailable = false;
                            return isAvailable;
                        }

                    }
                }
            }

            //tag deres colum og se om de er ledige.
            


            Reservation reservation = new Reservation();

            reservation.Seat = seatArray;
            reservation.Row = row;

            reservation.CustomerID = customerID;
            reservation.SchedulerID = schedulerID;


            return isAvailable;

            //Husk at den returner en controlInt for at se om programmet failet i at indsætte i databasen.
            //dbRes.insertReservation(reservation);

        }
    }
}
