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
        public List<Seat> GetSeats(int schID)
        {

            var db = new ConnectToDatabaseDataContext();

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
    }
}