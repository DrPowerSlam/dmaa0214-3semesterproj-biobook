using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class Reservation
    {
    
        private int resID;
        private int customerID;
        private Array rowArray;
        private Array seatArray;

        public int ResID
        {
            get { return resID; }
            set { resID = value; }
        }
       

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        private int schedulerID;

        public int SchedulerID
        {
            get { return schedulerID; }
            set { schedulerID = value; }
        }
 

        public Array RowArray
        {
            get { return rowArray; }
            set { rowArray = value; }
        }
    

        public Array SeatArray
        {
            get { return seatArray; }
            set { seatArray = value; }
        }


        public Reservation(int ResID, int CustomerID, int SchedulerID, Array RowArray, Array SeatArray)
        {
            this.ResID = ResID;
            this.CustomerID = CustomerID;
            this.SchedulerID = SchedulerID;
            this.RowArray = RowArray;
            this.SeatArray = SeatArray;
        }

    }
}
