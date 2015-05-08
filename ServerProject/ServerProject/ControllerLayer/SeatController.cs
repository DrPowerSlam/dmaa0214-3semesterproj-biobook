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
        public int[][] ConvertStringToArray(int schID)
        {
            DBSeat dbSeat = new DBSeat();
            var seatListoperator = dbSeat.GetSeats(schID);
            int count = seatListoperator.Count();


            int[][] jagged = new int[count][];

            for (int row = 0; row < count; row++)
            {
                Seat s = seatListoperator.ElementAt(row);
                //int tempCount = (int)s.ColumnArray.Count();
                int i = 0;
                int lengthChar = (1 + s.ColumnArray.Count()) / 2;
                jagged[row] = new int[lengthChar];
                Console.WriteLine("length: " + lengthChar);
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

        public string findBestSeats(int personer, int schID)
        {
            List<string> savedOption = new List<string>();
            int freeSeats = 0;
            // convert database info of the schedule to jagged array
            int[][] jaggedArray = ConvertStringToArray(schID);
            // loop through to see if enough seats are available
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    // if not 0, then the seat is available
                    if(jaggedArray[i][j] != 0)
                    {
                        freeSeats++;
                    }
                }
            }

            if(freeSeats < personer)
            {
                // there were not enough available seats available
                return "Could not find enough seats";
            }

            // enough seats were available, can we find enough adjecent seats?
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
                            possible == true && counter != personer; nextSeat++)
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
                    if(counter == personer && possible)
                    {
                        // start values
                        string savestring = y.ToString();
                        int point = jaggedArray[x][y];

                        // save the seats to a list
                        for(int next = 1; next < personer; next++)
                        {
                            savestring += "-" + (next + y);
                            point += jaggedArray[x][next + y];
                        }
                        savestring += "," + x;
                        savestring += "*"+point;
                        savedOption.Add(savestring);                       
                    }
                }
            }

            int bestPoint = 0;
            string bestSeats = "";
            string compareString = "";
            foreach(string s in savedOption)
            {   // Loop through the options, and return the best seats

                compareString = s.Substring(s.LastIndexOf("*")+1);

                if(bestPoint < int.Parse(compareString))
                {
                    bestPoint = int.Parse(compareString);
                    bestSeats = s;
                }
            }
            return bestSeats;


        }
    }
}


