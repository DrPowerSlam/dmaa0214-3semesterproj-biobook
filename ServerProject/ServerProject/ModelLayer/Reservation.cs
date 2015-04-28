using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerProject.ModelLayer
{
    public class Reservation
    {
    
        private int resID;
        private int customerID;
        private Customer customer;
        private int rowArray;
        private int seatArray;
        private int schedulerID;

        public Reservation(int ResID, int CustomerID, int SchedulerID, int RowArray, int SeatArray)
        {
            this.ResID = ResID;
            this.customerID = CustomerID;
            this.SchedulerID = SchedulerID;
            this.RowArray = RowArray;
            this.SeatArray = SeatArray;
        }

        public Reservation()
        {
            ResID = -1;
            customerID = -1;
            SchedulerID = -1;
            rowArray = -1;
            seatArray = -1;
            customer = null;
        }

        public int ResID
        {
            get { return resID; }
            set { resID = value; }
        }
       

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public int SchedulerID
        {
            get { return schedulerID; }
            set { schedulerID = value; }
        }
 

        public int RowArray
        {
            get { return rowArray; }
            set { rowArray = value; }
        }
    

        public int SeatArray
        {
            get { return seatArray; }
            set { seatArray = value; }
        }
    }
}
