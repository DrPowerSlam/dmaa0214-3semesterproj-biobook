using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerProject.DatabaseLayer
{
    public class DBSeat
    {
        static int lengthChar;
        public void main()
        {
            GetSeats(1);
        }
        public void GetSeats(int schID)
        {

            var db = new ConnectToDatabaseDataContext();
            List<Seat> seatListoperator = new List<Seat>();

            seatListoperator = db.Seats.Where(x => x.SchedulerID == schID).ToList();

            int count = seatListoperator.Count();


            int[][] jagged = new int[count][];

            for (int row = 0; row < count; row++ )
            {
                Seat s = seatListoperator.ElementAt(row);
                //int tempCount = (int)s.ColumnArray.Count();
                int i = 0;
                lengthChar = (1 + s.ColumnArray.Count()) / 2;
                jagged[row] = new int[lengthChar];
                Console.WriteLine("length: " +lengthChar);
                foreach (char c in s.ColumnArray)
                {
                    if (!c.Equals(','))
                    {
                        jagged[row][i] = (int)Char.GetNumericValue(c);
                        i++;
                    }
                }
            }
                // Testing translater
                Console.WriteLine(count);
                for (int column = 0; column < count; column++)
                {
                    for (int number = 0; number < jagged[column].Count();  number++)
                    {
                        Console.WriteLine(jagged[column][number]);
                    }
                    Console.ReadLine();
                }

    }
