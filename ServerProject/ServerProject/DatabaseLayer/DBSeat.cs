using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerProject.DatabaseLayer
{
    public class DBSeat
    {
        static int lengthChar;
        ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
        
        /// <summary>
        /// Gets all seats in a given scheduler
        /// </summary>
        /// <param name="schID">The ID of the scheduler</param>
        /// <returns>Returns a list of the seats</returns>
        public List<Seat> GetSeats(int schID)
        {
            return db.Seats.Where(x => x.SchedulerID == schID).ToList();

            //// Testing translater
            //Console.WriteLine(count);
            //for (int column = 0; column < count; column++)
            //{
            //    for (int number = 0; number < jagged[column].Count(); number++)
            //    {
            //        Console.WriteLine(jagged[column][number]);
            //    }
            //    Console.ReadLine();
            //}

        }

        public List<Seat> GetSeatsBySchIDAndRow(int schID, int row)
        {
            List<Seat> record = db.Seats.Where(x => x.SchedulerID == schID && x.Row == row).ToList();
            return record;
        }

        public void InsertSeat()
        {
            //
        }

        public void UpdateSeat(string rows, string seats, int schID)
        {
            //see if the seats are already there and then update it
            //therefore check for schedulerID and row. If they are the same, then update it.
            string[] rowsArray = rows.Split(',');
            string[] seatsArray = seats.Split(',');
            Seat seatFromDB = new Seat();
            Seat seatToDB = new Seat();
            //get only the rows and seats with the schID
            DBSeat seatDB = new DBSeat();
            foreach(string row in rowsArray)
            {
                int rowIndex;
                Int32.TryParse(row, out rowIndex);

                //this should only take one from the database.
                //although if that row does not exists then make an error
                seatFromDB = seatDB.GetSeatsBySchIDAndRow(schID,rowIndex).First();
                if (seatFromDB == null)
                {
                    throw new Exception("There are no such row in the database");
                }

                if (seatFromDB.ColumnArray.Length == seatsArray.Length)
                {
                    //then you can make the update, to that row and ColumnArray
                    
                    seatToDB.ColumnArray = seats;
                    seatToDB.Row = rowIndex;
                    seatToDB.SchedulerID = schID;
                    db.Seats.InsertOnSubmit(seatToDB);
                }
                
            }   
            //if the scheduler does not exists then make a new one?
            //why?


        }
    }
}