using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServerProject.DatabaseLayer;

namespace ServerProject.ControllerLayer
{
    class SeatController
    {
        public Array ConvertStringToArray(int schID)
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
    }
}
