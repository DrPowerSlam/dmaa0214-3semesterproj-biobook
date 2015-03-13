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

        public string getSetHallName
        {
            get { return hallName; }
            set { hallName = value; }
        }

        public int getSetHallID
        {
            get { return hallID; }
            set { hallID = value; }
        }

        public string getSetMaxNumberOfSeats
        {
            get { return maxNumberOfSeats; }
            set { maxNumberOfSeats = value; }
        }
    }
}
