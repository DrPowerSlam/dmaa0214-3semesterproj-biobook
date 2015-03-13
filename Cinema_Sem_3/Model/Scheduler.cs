using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Scheduler
    {
        private int schID;
        private DateTime date;
        private int timeInMinutes;
        private Movie movie;
        private Hall hall;
        private int endTimeInMinutes;

        public int SchID
        {
            get { return schID; }
            set { schID = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public int TimeInMinutes
        {
            get { return timeInMinutes; }
            set { timeInMinutes = value; }
        }

        internal Movie Movie
        {
            get { return movie; }
            set { movie = value; }
        }

        internal Hall Hall
        {
            get { return hall; }
            set { hall = value; }
        }

        public int EndTimeInMinutes
        {
            get { return endTimeInMinutes; }
            set { endTimeInMinutes = value; }
        }
    }
}
