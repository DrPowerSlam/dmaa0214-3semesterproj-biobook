using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Seat
    {
        private int seatID;
        private int row;
        private int[] columSeats;

        public int Row
        {
            get { return row; }
            set { row = value;  }
        }

        public int SeatID
        {
            get { return seatID; }
            set { seatID = value; }
        }

        public int[] ColumSeat
        {
            get { return columSeats; }
            set { columSeats = value; }
        }

        public Seat(int seatID, int[] columSeats, int row)
        {
            SeatID = seatID;
            ColumSeat = columSeats;
            Row = row;
        }
    }
}
