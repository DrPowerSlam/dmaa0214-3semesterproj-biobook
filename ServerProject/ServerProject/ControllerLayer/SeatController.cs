using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerProject.DatabaseLayer;

namespace ServerProject.ControllerLayer
{
    public class SeatController
    {
        static int counter;

        /// <summary>
        /// Gets all seats by a scheduler ID
        /// </summary>
        /// <param name="schedulerID">The ID of the scheduler</param>
        /// <returns>Returns a list of seats</returns>
        public List<Seat> GetAllSeatsBySchedulerID(int schedulerID)
        {
            DBSeat dbSeat = new DBSeat();
            return dbSeat.GetSeats(schedulerID);
        }

        /// <summary>
        /// Converts a string from the database to a jagged array
        /// </summary>
        /// <param name="schID">The scheduler ID of the seats you want to convert</param>
        /// <returns>Returns the jagged array</returns>
        public int[][] ConvertStringToArray(int schID)
        {
            DBSeat dbSeat = new DBSeat();
            var seatListoperator = dbSeat.GetSeats(schID);
            int count = seatListoperator.Count();


            int[][] jagged = new int[count][];

            for (int row = 0; row < count; row++)
            {
                Seat s = seatListoperator.ElementAt(row);
                int i = 0;
                int lengthChar = (1 + s.ColumnArray.Count()) / 2;
                jagged[row] = new int[lengthChar];
                foreach (char c in s.ColumnArray)
                {
                    if (!c.Equals(','))
                    {
                        jagged[row][i] = (int)Char.GetNumericValue(c);
                        i++;
                    }
                }
            }

            return jagged;
        }

        /// <summary>
        /// Finds the best seats for an amount of people
        /// </summary>
        /// <param name="personer">The amount of people that wants to reserve seats</param>
        /// <param name="schID">The scheduler ID where you want to reserve seats</param>
        /// <returns>Returns an array of the best seats</returns>
        public int[] FindBestSeats(int amountOfPeople, int schID)
        {
            List<int[]> savedOption = new List<int[]>();
            int freeSeats = 0;
            // convert database info of the schedule to jagged array
            int[][] jaggedArray = ConvertStringToArray(schID);
            // loop through to see if enough seats are available
            int i = 0;
            int j = 0;
            while (freeSeats < amountOfPeople && i < jaggedArray.Length)
            {
                j = 0;
                while (freeSeats < amountOfPeople && j < jaggedArray[i].Length)
                {
                    // if not 0, then the seat is available
                    if(jaggedArray[i][j] != 0)
                    {
                        freeSeats++;
                    }
                    j++;
                }
                i++;
            }

            if (freeSeats < amountOfPeople)
            {
                // there were not enough available seats available
                return null;
            }

            // enough seats were available, can we find enough adjecent seats?
            // x is the row y is the seat in the row
            for (int x = 0; x < jaggedArray.Length; x++)
            {
                for (int y = 0; y < jaggedArray[x].Length; y++)
                {
                    // for now we assume its possible to find the amount of seats
                    bool possible = true;
                    // if the current selected seat is available, check if enough
                    // seats around it are available
                    if(jaggedArray[x][y] != 0)
                    {
                        counter = 1;
                        for(int nextSeat = y+1 ; nextSeat < jaggedArray[x].Length &&
                            possible == true && counter != amountOfPeople; nextSeat++)
                        {
                            if(jaggedArray[x][nextSeat] != 0)
                            {   // if the seat was available, count found adjecent
                                // seats up with 1
                                counter++;
                            }
                            else
                            {   // if an adjecent seat wasn't available when it was
                                // needed, try the next startpoisition, since this startseat wasn't possible
                                possible = false;
                            }
                        }
                    }
                    // if enough seats where found, save them as a possible option
                    if (counter == amountOfPeople && possible)
                    {
                        // start values
                        int[] saveArray = new int[amountOfPeople + 2];
                        int point = 0;

                        // save the seats to a list
                        for (int next = 0; next < amountOfPeople; next++)
                        {
                            saveArray[next + 2] = y + next+1;
                            point += jaggedArray[x][next + y];
                        }
                        saveArray[0] = point;
                        saveArray[1] = x+1;
                        savedOption.Add(saveArray);                       
                    }
                }
            }
            if(savedOption.Count == 0)
            {
                return null;
            }
            int bestPoint = 0;
            // If one or more options are found, they will always need room for 
            // amount of people+2 ( for row number and point)
            int[] bestSeats = new int[amountOfPeople + 2];
                foreach (int[] option in savedOption)
                {   // Loop through the options, and return the best seats
                    // check each of the options total point, and if better than current best
                    // option, replace best option
                    if (bestPoint < option[0])
                    {
                        bestPoint = option[0];
                        bestSeats = option;
                    }
                }    
            
            return bestSeats;


        }

        /// <summary>
        /// A test method for the previous methods
        /// </summary>
        public void Easytest()
        {
            int[] p = FindBestSeats(3, 1);
            if (p == null)
            {
                Console.WriteLine("nederen");
            }
            else
            {
                Console.WriteLine("Rækken er: " + (p[1]));
                Console.WriteLine("Total point er :" + p[0]);
                Console.WriteLine("sæderne er: ");
                for (int x = 2; x < p.Length; x++)
                    Console.WriteLine((p[x]) + ", ");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Checks if some seats are avaiable. Returns them if they are
        /// </summary>
        /// <param name="schID">The scheduler ID of the seats you want to check</param>
        /// <returns>Returns an array of the available seats</returns>
        public int[][] ListAvailable(int schID)
        {
           int[][] array = ConvertStringToArray(schID);
           for(int x = 0; x < array.Length ; x++)
           {
               for(int y = 0; y < array[x].Length; y++)
               {
                   if(array[x][y] != 0)
                   {
                       array[x][y] = y+1;
                   }
               }
           }
           return array;
        }


    }
}


