using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Hall
    {
        private int hallID;
        private int maxNumberOfSeats;
        private string hallName;

        public Hall(int hallID, int maxNumberOfSeats, string hallName)
        {
            this.hallID = hallID;
            this.maxNumberOfSeats = maxNumberOfSeats;
            this.hallName = hallName;
        }

         public Hall()
        {
            //hallName = null;
            //hallID = -1;
        }


        public string HallName
        {
            get { return hallName; }
            set { hallName = value; }
        }

        public int HallID
        {
            get { return hallID; }
            set { hallID = value; }
        }

        public int MaxNumberOfSeats
        {
            get { return maxNumberOfSeats; }
            set { maxNumberOfSeats = value; }
        }
    }
}
