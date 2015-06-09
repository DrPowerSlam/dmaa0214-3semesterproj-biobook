using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data;

namespace ServerProject.DatabaseLayer
{
    public class DBSeat
    {

        /// <summary>
        /// Gets all seats in a given scheduler
        /// </summary>
        /// <param name="schID">The ID of the scheduler</param>
        /// <returns>Returns a list of the seats</returns>
        public List<Seat> GetSeats(int schID)
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            List<Seat> seat = db.Seats.Where(x => x.SchedulerID == schID).ToList();
            return seat;
            // Testing translater
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

        /// <summary>
        /// Gets a seat object by it's scheduler ID and row
        /// </summary>
        /// <param name="schID">The scheduler ID of the seats</param>
        /// <param name="row">The row of the seats</param>
        /// <returns>A list of the seats with that row (should only be 1 though)</returns>
        public List<Seat> GetSeatsBySchIDAndRow(int schID, int row)
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();
            List<Seat> record = db.Seats.Where(x => x.SchedulerID == schID && x.Row == row).ToList();
            return record;

        }

        /// <summary>
        /// Update a number of given seats, on specific rows, with specific data on a specific scheduler
        /// </summary>
        /// <param name="rows">The rows of the seats</param>
        /// <param name="seats">The seats you want to update (by their index)</param>
        /// <param name="updateInfo">The info you want to update the seats with (e.g. 0, for reserved), in a char array. Enter in succession of the seat index</param>
        /// <param name="schID">The scheduler of the seats</param>
        public void UpdateSeat(string rows, string seats,string updateInfo, int schID)
        {
            ConnectToDatabaseDataContext db = new ConnectToDatabaseDataContext();

            db.Connection.Open();
            db.Transaction = db.Connection.BeginTransaction(IsolationLevel.RepeatableRead);
            seats = seats.Replace(" ", "");
            rows = rows.Replace(" ", "");
            //Create some arrays that doesn't have comma (the seperator in our strings)
            string[] rowsArray = rows.Split(',');
            string[] seatsArray = seats.Split(',');

            //string[] updateArray = updateInfo.Split(',');
            //Create a seat object that will hold the seats from the database
            Seat seatFromDB = new Seat();
            //Loop through all the rows
            foreach(string row in rowsArray)
            {
                //Index for the seats, so we know which element we are at
                int seatIndex = 0;
                //Index for the rows
                int rowIndex;
                Int32.TryParse(row, out rowIndex);

                //Gets the first (and only) seat from the database
                seatFromDB = GetSeatsBySchIDAndRow(schID,rowIndex).First();
                //Convert the seats from the database to a char array (so the program can replace chars at certain indices
                string[] charArray = seatFromDB.ColumnArray.Split(',');
                //Check if it's non-exsistent
                //If not, check if they are equal in length (compared to the input seat)
                if (seatFromDB != null)
                {
                    foreach (char updateChar in updateInfo)
                    {
                        //if (int.Parse(seatsArray[seatIndex]) == 0)
                        //    charArray[int.Parse(seatsArray[seatIndex])] = updateInfo[updateInfoIndex];
                        //else if (int.Parse(seatsArray[seatIndex]) % 2 == 0)
                        //    charArray[int.Parse(seatsArray[seatIndex])+2] = updateInfo[updateInfoIndex];
                        //else if (int.Parse(seatsArray[seatIndex]) % 2 != 0)
                        //    charArray[int.Parse(seatsArray[seatIndex])*2] = updateInfo[updateInfoIndex];

                        charArray[int.Parse(seatsArray[seatIndex])-1] = updateInfo[seatIndex].ToString();

                        //SeatIndex only counts up in this else if condition, since we have no reason to add to it if there is no database
                        seatIndex++;
                    }
                }
                else if (seatFromDB == null)
                {
                    throw new Exception("There is no such row in the database");
                }
                string stringToUpload = "";
                if (charArray.Length != 0)
                {
                    for (int i = 0; i < charArray.Length; i++)
                    {
                        stringToUpload = stringToUpload + charArray[i] + ",";
                    }
                    
                }
                stringToUpload = stringToUpload.Remove(stringToUpload.Length - 1);
                seatFromDB.ColumnArray = stringToUpload;
            }
            try
            {
                 
                db.Transaction.Commit();
                db.Transaction.Dispose();
                db.Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                db.Transaction.Rollback();
                db.Connection.Close();
            }
        }

        /// <summary>
        /// Checks if selected seats are already occupied
        /// </summary>
        /// <param name="rows">The rows of the seats</param>
        /// <param name="seatsToCheck">The index of the seats to check</param>
        /// <param name="schID">The scheduler ID for the seats</param>
        public void CheckForReservation(string rows, string seatsToCheck, int schID)
        {
            string[] singleRow = rows.Split(',');
            string[] singleSeat = seatsToCheck.Split(',');
            foreach (string row in singleRow)
            {
                Seat seat = GetSeatsBySchIDAndRow(schID, int.Parse(row)).First();
                int seatIndex = 0;
                if(seat.ColumnArray[int.Parse(singleSeat[seatIndex])] == 0)
                {
                    throw new Exception("One or more seat is already occupied");
                }
                seatIndex++;
            }
        }
    }
}