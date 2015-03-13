using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Hall
    {
        private int hallID;
        private string maxNumberOfSeats;
        private string hallName;

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

        public string MaxNumberOfSeats
        {
            get { return maxNumberOfSeats; }
            set { maxNumberOfSeats = value; }
        }
    }
}
