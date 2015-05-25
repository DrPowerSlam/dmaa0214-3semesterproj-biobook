using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

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

        public void UpdateSeat(string rows, string seats,char[] updateInfo, int schID)
        {
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
                int updateInfoIndex = 0;
                //Index for the rows
                int rowIndex;
                Int32.TryParse(row, out rowIndex);

                //Gets the first (and only) seat from the database
                seatFromDB = GetSeatsBySchIDAndRow(schID,rowIndex).First();
                //Convert the seats from the database to a char array (so the program can replace chars at certain indices
                char[] charArray = seatFromDB.ColumnArray.ToCharArray();
                //Check if it's non-exsistent
                //If not, check if they are equal in length (compared to the input seat)
                if (seatFromDB != null)
                {
                    foreach (char updateChar in updateInfo)
                    {
                        if (int.Parse(seatsArray[seatIndex]) == 0)
                            charArray[int.Parse(seatsArray[seatIndex])] = updateInfo[updateInfoIndex];
                        else if (int.Parse(seatsArray[seatIndex]) % 2 == 0)
                            charArray[int.Parse(seatsArray[seatIndex])+2] = updateInfo[updateInfoIndex];
                        else if (int.Parse(seatsArray[seatIndex]) % 2 != 0)
                            charArray[int.Parse(seatsArray[seatIndex])*2] = updateInfo[updateInfoIndex];

                        //SeatIndex only counts up in this else if condition, since we have no reason to add to it if there is no database
                        seatIndex++;
                        updateInfoIndex++;
                    }
                }
                else if (seatFromDB == null)
                {
                    throw new Exception("There is no such row in the database");
                }
                string stringToUpload = new string(charArray);
                seatFromDB.ColumnArray = stringToUpload;
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                db.Transaction.Rollback();
            }
        }
    }
}