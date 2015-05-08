using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;

namespace ServerProject.ModelLayer
{
    public class Customer : DatabaseLayer.Customer
    {

        private string name;
        private int cusID;
        private string phoneNumber;

        public Customer()
        {
            name = null;
            cusID = -1;
            phoneNumber = "";
        }

        public Customer(string name, int cusID, string phoneNumber)
        {
            this.name = name;
            this.cusID = cusID;
            this.phoneNumber = phoneNumber;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int CusID
        {
            get { return cusID; }
            set { cusID = value; }
        }

        public Customer(int ID, string Name)
        {
            this.CusID = ID;
            this.Name = Name;
        }


    }
}
